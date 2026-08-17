using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmBuscarCliente : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public Cliente ClienteSeleccionado = null;
        public bool ModoExplorar = false;

        public FrmBuscarCliente()
        {
            InitializeComponent();
            Load += FrmBuscarCliente_Load;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            btnSeleccionar.Click += btnSeleccionar_Click;
            btnConsumidor.Click += btnConsumidor_Click;
            btnDetalles.Click += btnDetalles_Click;
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            if (ModoExplorar)
            {
                Text = "Explorar clientes";
                btnConsumidor.Visible = false;
                btnSeleccionar.Text = "Ver detalles";
            }

            clientes = new ClienteNegocio().Listar().Where(c => c.Estado).ToList();
            MostrarClientes(clientes);
        }

        private void MostrarClientes(List<Cliente> lista)
        {
            dgvClientes.DataSource = lista;

            string[] visibles = { "Nombre", "Apellido", "Cedula", "Telefono" };
            foreach (DataGridViewColumn columna in dgvClientes.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.ToLower();
            var filtrados = clientes.Where(c => c.NombreCompleto.ToLower().Contains(texto)
                || (c.Cedula != null && c.Cedula.Contains(texto))).ToList();
            MostrarClientes(filtrados);
        }

        private void Seleccionar()
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            if (ModoExplorar)
            {
                new FrmClienteDetalle(cliente).ShowDialog(this);
                return;
            }

            ClienteSeleccionado = cliente;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Seleccionar();
        }

        private void btnConsumidor_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            new FrmClienteDetalle(cliente).ShowDialog(this);
        }
    }
}
