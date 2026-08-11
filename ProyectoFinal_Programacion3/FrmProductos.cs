using System;
using System.Windows.Forms;
using CapaEntidades;
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

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Producto seleccionado = (Producto)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmProducto dialogo = new FrmProducto(seleccionado);
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = productoNegocio.Listar();
            }
        }
    }
}
