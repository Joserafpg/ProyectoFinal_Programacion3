using System;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmLogin : Form
    {
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // aqui va la logica del login
            var usuario = usuarioNegocio.Login(txtUsuario.Text, txtClave.Text, out string mensaje);

            if(mensaje == "")
            {
                Sesion.UsuarioActual = usuario;
                this.Hide();
                FrmPrincipal principal = new FrmPrincipal();
                principal.ShowDialog();
                txtClave.Clear();
                this.Show();
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
