using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmClientes : Form
    {

        ClienteNegocio clienteNegocio = new ClienteNegocio();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = clienteNegocio.Listar();
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
            FrmCliente dialogo = new FrmCliente(seleccionado);
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = clienteNegocio.Listar();
            }
        }
    }
}
