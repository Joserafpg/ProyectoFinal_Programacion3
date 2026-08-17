using CapaEntidades;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmMarcas : Form
    {
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = marcaNegocio.Listar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Nombre", "Estado");
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMarca dialogo = new FrmMarca();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = marcaNegocio.Listar();
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            else
            {
                Marca seleccionada = (Marca)dgvDatos.Rows[e.RowIndex].DataBoundItem;
                FrmMarca dialogo = new FrmMarca(seleccionada);
                if (dialogo.ShowDialog(this) == DialogResult.OK)
                {
                    dgvDatos.DataSource = marcaNegocio.Listar();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = marcaNegocio.Listar(txtBuscar.Text);
        }
    }
}
