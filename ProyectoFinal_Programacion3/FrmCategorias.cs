using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCategorias : Form
    {
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = categoriaNegocio.Listar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCategoria dialogo = new FrmCategoria();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = categoriaNegocio.Listar();
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {

                Categoria seleccionada = (Categoria)dgvDatos.Rows[e.RowIndex].DataBoundItem;
                FrmCategoria dialogo = new FrmCategoria(seleccionada);
                if (dialogo.ShowDialog(this) == DialogResult.OK)
                {
                    dgvDatos.DataSource = categoriaNegocio.Listar();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = categoriaNegocio.Listar(txtBuscar.Text);
        }
    }
}
