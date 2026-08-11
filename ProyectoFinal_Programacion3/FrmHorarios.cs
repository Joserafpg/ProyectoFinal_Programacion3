using System;
using System.Windows.Forms;
using CapaEntidades;
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

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmHorario dialogo = new FrmHorario();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = horarioNegocio.Listar();
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Horario seleccionado = (Horario)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmHorario dialogo = new FrmHorario(seleccionado);
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = horarioNegocio.Listar();
            }
        }
    }
}
