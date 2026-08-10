using System;
using System.Windows.Forms;
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
    }
}

