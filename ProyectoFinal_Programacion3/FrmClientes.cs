using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmClientes : Form
    {

        ClienteNegocio clienteNegocio = new ClienteNegocio();
        List<Cliente> clientes = new List<Cliente>();

        public FrmClientes()
        {
            InitializeComponent();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.ToLower();
            dgvDatos.DataSource = clientes.Where(c => c.NombreCompleto.ToLower().Contains(texto)
                || (c.Cedula != null && c.Cedula.Contains(texto))).ToList();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            clientes = clienteNegocio.Listar();
            dgvDatos.DataSource = clientes;
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCliente dialogo = new FrmCliente();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = clienteNegocio.Listar();
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Cliente seleccionado = (Cliente)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmClienteDetalle detalle = new FrmClienteDetalle(seleccionado);
            if (detalle.ShowDialog(this) == DialogResult.OK)
            {
                clientes = clienteNegocio.Listar();
                dgvDatos.DataSource = clientes;
            }
        }
    }
}
