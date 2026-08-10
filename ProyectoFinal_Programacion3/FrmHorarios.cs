using System;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmHorarios : Form
    {
        HorarioNegocio horarioNegocio = new HorarioNegocio();
        public FrmHorarios()
        {
            InitializeComponent();
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = horarioNegocio.Listar();
        }
    }
}

