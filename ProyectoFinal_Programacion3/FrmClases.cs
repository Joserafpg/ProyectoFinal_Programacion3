using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmClases : Form
    {
        ClaseNegocio claseNegocio = new ClaseNegocio();
        public FrmClases()
        {
            InitializeComponent();
        }

        private void FrmClases_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = claseNegocio.Listar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmClase dialogo = new FrmClase();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = claseNegocio.Listar();
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Clase seleccionado = (Clase)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmClase dialogo = new FrmClase(seleccionado);
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = claseNegocio.Listar();
            }
        }
    }
}
