using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmHorario : Form
    {
        HorarioNegocio horarioNegocio = new HorarioNegocio();
        Horario horarioEditar = null;

        public FrmHorario()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            txtNombre.KeyPress += Validaciones.SoloLetras;
            btnDesactivar.Visible = false;
        }

        public FrmHorario(Horario horario) : this()
        {
            horarioEditar = horario;

            Text = "Editar Horario";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = horario.Nombre;

            string[] partes = horario.Dias.Split(new string[] { " a " }, StringSplitOptions.None);
            cboDiaDesde.Text = partes[0];
            if (partes.Length > 1)
            {
                cboDiaHasta.Text = partes[1];
            }

            dtpHoraInicio.Value = DateTime.Today.Add(horario.HoraInicio);
            dtpHoraFin.Value = DateTime.Today.Add(horario.HoraFin);

            btnDesactivar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboDiaDesde.SelectedIndex == -1 || cboDiaHasta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar los días del horario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje;

            if (horarioEditar == null)
            {
                Horario horario = new Horario();
                horario.Nombre = txtNombre.Text;
                horario.Dias = cboDiaDesde.Text + " a " + cboDiaHasta.Text;
                horario.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                horario.HoraFin = dtpHoraFin.Value.TimeOfDay;
                horario.Estado = true;

                mensaje = horarioNegocio.Insertar(horario);
            }
            else
            {
                horarioEditar.Nombre = txtNombre.Text;
                horarioEditar.Dias = cboDiaDesde.Text + " a " + cboDiaHasta.Text;
                horarioEditar.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                horarioEditar.HoraFin = dtpHoraFin.Value.TimeOfDay;

                mensaje = horarioNegocio.Actualizar(horarioEditar);
            }

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Operacion realizada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de desactivar este horario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = horarioNegocio.CambiarEstado(horarioEditar.IdHorario, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Horario desactivado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
