using System;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmEntrenadores : Form
    {
        EntrenadorNegocio entrenadorNegocio = new EntrenadorNegocio();
        public FrmEntrenadores()
        {
            InitializeComponent();
        }

        private void FrmEntrenadores_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = entrenadorNegocio.Listar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEntrenador dialogo = new FrmEntrenador();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = entrenadorNegocio.Listar();
            }
        }
    }
}
