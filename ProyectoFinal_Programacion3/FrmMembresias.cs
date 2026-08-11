using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmMembresias : Form
    {
        MembresiaNegocio membresiaNegocio = new MembresiaNegocio();
        public FrmMembresias()
        {
            InitializeComponent();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void FrmMembresias_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = membresiaNegocio.Listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMembresia dialogo = new FrmMembresia();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = membresiaNegocio.Listar();
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Membresia seleccionado = (Membresia)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmMembresia dialogo = new FrmMembresia(seleccionado);
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = membresiaNegocio.Listar();
            }
        }
    }
}
