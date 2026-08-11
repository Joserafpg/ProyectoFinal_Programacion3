using System;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmProductos : Form
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = productoNegocio.Listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto dialogo = new FrmProducto();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = productoNegocio.Listar();
            }
        }
    }
}
