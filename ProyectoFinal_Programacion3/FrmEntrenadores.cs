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
    }
}

