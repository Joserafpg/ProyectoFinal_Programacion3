using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmUsuario : Form
    {
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        Usuario usuarioEditar = null;

        public FrmUsuario()
        {
            InitializeComponent();
            txtNombreCompleto.KeyPress += Validaciones.SoloLetras;

            cboRol.DataSource = new RolNegocio().Listar();
            cboRol.DisplayMember = "Nombre";
            cboRol.ValueMember = "IdRol";

            btnDesactivar.Visible = false;
        }

        public FrmUsuario(Usuario usuario) : this()
        {
            usuarioEditar = usuario;

            Text = "Editar Usuario";
            btnGuardar.Text = "Actualizar";

            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtNombreCompleto.Text = usuario.NombreCompleto;
            txtCorreo.Text = usuario.Correo;
            cboRol.SelectedValue = usuario.IdRol;

            txtClave.Enabled = false;
            btnDesactivar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboRol.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje;

            if (usuarioEditar == null)
            {
                Usuario usuario = new Usuario();
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.NombreCompleto = txtNombreCompleto.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.IdRol = (int)cboRol.SelectedValue;
                usuario.Estado = true;

                mensaje = usuarioNegocio.Insertar(usuario, txtClave.Text);
            }
            else
            {
                usuarioEditar.NombreUsuario = txtNombreUsuario.Text;
                usuarioEditar.NombreCompleto = txtNombreCompleto.Text;
                usuarioEditar.Correo = txtCorreo.Text;
                usuarioEditar.IdRol = (int)cboRol.SelectedValue;

                mensaje = usuarioNegocio.Actualizar(usuarioEditar);
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
            if (MessageBox.Show("¿Está seguro de desactivar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = usuarioNegocio.CambiarEstado(usuarioEditar.IdUsuario, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Usuario desactivado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
