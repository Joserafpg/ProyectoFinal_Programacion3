using System;
using System.Windows.Forms;
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
    }
}
