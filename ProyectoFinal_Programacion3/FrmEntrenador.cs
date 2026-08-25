using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmEntrenador : Form
    {
        EntrenadorNegocio entrenadorNegocio = new EntrenadorNegocio();
        Entrenador entrenadorEditar = null;

        public FrmEntrenador()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            txtNombre.KeyPress += Validaciones.SoloLetras;
            txtApellido.KeyPress += Validaciones.SoloLetras;
            txtCedula.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtTelefono.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtEspecialidad.KeyPress += Validaciones.SoloLetras;

            cboHorario.DataSource = new HorarioNegocio().Listar();
            cboHorario.DisplayMember = "Nombre";
            cboHorario.ValueMember = "IdHorario";

            btnDesactivar.Visible = false;
        }

        public FrmEntrenador(Entrenador entrenador) : this()
        {
            entrenadorEditar = entrenador;

            Text = "Editar Entrenador";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = entrenador.Nombre;
            txtApellido.Text = entrenador.Apellido;
            txtCedula.Text = entrenador.Cedula;
            txtTelefono.Text = entrenador.Telefono;
            txtCorreo.Text = entrenador.Correo;
            txtEspecialidad.Text = entrenador.Especialidad;
            cboHorario.SelectedValue = entrenador.IdHorario;

            EstadoToggle.Reemplazar(btnDesactivar, entrenador.Estado, "este entrenador", estado => entrenadorNegocio.CambiarEstado(entrenador.IdEntrenador, estado));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboHorario.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un horario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje;

            if (entrenadorEditar == null)
            {
                Entrenador entrenador = new Entrenador();
                entrenador.Nombre = txtNombre.Text;
                entrenador.Apellido = txtApellido.Text;
                entrenador.Cedula = txtCedula.Text;
                entrenador.Telefono = txtTelefono.Text;
                entrenador.Correo = txtCorreo.Text;
                entrenador.Especialidad = txtEspecialidad.Text;
                entrenador.IdHorario = (int)cboHorario.SelectedValue;
                entrenador.Estado = true;

                mensaje = entrenadorNegocio.Insertar(entrenador);
            }
            else
            {
                entrenadorEditar.Nombre = txtNombre.Text;
                entrenadorEditar.Apellido = txtApellido.Text;
                entrenadorEditar.Cedula = txtCedula.Text;
                entrenadorEditar.Telefono = txtTelefono.Text;
                entrenadorEditar.Correo = txtCorreo.Text;
                entrenadorEditar.Especialidad = txtEspecialidad.Text;
                entrenadorEditar.IdHorario = (int)cboHorario.SelectedValue;

                mensaje = entrenadorNegocio.Actualizar(entrenadorEditar);
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
            if (MessageBox.Show("¿Está seguro de desactivar este entrenador?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = entrenadorNegocio.CambiarEstado(entrenadorEditar.IdEntrenador, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Entrenador desactivado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
