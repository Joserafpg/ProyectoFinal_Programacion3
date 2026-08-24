using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmAgregarPago : Form
    {
        Cliente cliente = null;
        List<string> yaAgregados = new List<string>();
        BindingList<PagoPendiente> pendientes = new BindingList<PagoPendiente>();

        // lo que el usuario fue agregando; el que abre el dialogo lo recoge de aqui
        public List<PagoPendiente> Agregados = new List<PagoPendiente>();

        public FrmAgregarPago()
        {
            InitializeComponent();
            Load += FrmAgregarPago_Load;
            dgvPendientes.CellDoubleClick += dgvPendientes_CellDoubleClick;
            dgvPendientes.DataBindingComplete += dgvPendientes_DataBindingComplete;
            btnAgregar.Click += btnAgregar_Click;
            btnCerrar.Click += btnCerrar_Click;
        }

        public FrmAgregarPago(Cliente clienteSeleccionado, List<string> conceptosEnCarrito) : this()
        {
            cliente = clienteSeleccionado;
            yaAgregados = conceptosEnCarrito;
        }

        private void FrmAgregarPago_Load(object sender, EventArgs e)
        {
            if (cliente == null) return;

            Text = "Pendientes de " + cliente.NombreCompleto;

            bool carritoTieneMembresia = yaAgregados.Any(c => c.StartsWith("Membresía") || c.StartsWith("Renovar"));

            foreach (var pendiente in new PagoNegocio().ListarPendientes(cliente))
            {
                if (yaAgregados.Contains(pendiente.Concepto)) continue;
                if (carritoTieneMembresia && pendiente.Membresia != null) continue;

                pendientes.Add(pendiente);
            }

            if (pendientes.Count == 0)
            {
                lblInfo.Text = "El cliente no tiene ningún pago pendiente.";
            }

            dgvPendientes.DataSource = pendientes;
        }

        private void dgvPendientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvPendientes, "Tipo", "Concepto", "Monto");

            if (dgvPendientes.Columns.Contains("Monto"))
            {
                dgvPendientes.Columns["Tipo"].FillWeight = 60;
                dgvPendientes.Columns["Concepto"].FillWeight = 200;
                dgvPendientes.Columns["Monto"].FillWeight = 60;
                dgvPendientes.Columns["Monto"].DefaultCellStyle.Format = "N2";
            }

            dgvPendientes.ClearSelection();
            dgvPendientes.CurrentCell = null;
        }

        private void Agregar()
        {
            if (dgvPendientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pendiente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PagoPendiente item = (PagoPendiente)dgvPendientes.CurrentRow.DataBoundItem;

            Agregados.Add(item);
            pendientes.Remove(item);

            // solo se puede cobrar una membresia por pago, se quitan las demas opciones
            if (item.Membresia != null)
            {
                foreach (var otro in pendientes.Where(p => p.Membresia != null).ToList())
                {
                    pendientes.Remove(otro);
                }
            }

            if (pendientes.Count == 0)
            {
                Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void dgvPendientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Agregar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
