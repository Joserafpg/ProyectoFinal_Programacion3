using CapaEntidades;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmHorarios : Form
    {
        HorarioNegocio horarioNegocio = new HorarioNegocio();
        ComboBox cboEstado;

        public FrmHorarios()
        {
            InitializeComponent();
            cboEstado = Filtros.AgregarEstado(panelBarra);
            cboEstado.SelectedIndexChanged += (s, e) => Cargar();
        }

        private void Cargar()
        {
            dgvDatos.DataSource = horarioNegocio.Listar(txtBuscar.Text, Filtros.Estado(cboEstado));
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Nombre", "Dias=Días", "HoraInicio=Hora inicio", "HoraFin=Hora fin", "Estado");
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmHorario dialogo = new FrmHorario();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                Cargar();
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
                Cargar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
