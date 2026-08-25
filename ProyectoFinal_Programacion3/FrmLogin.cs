using System;
using System.Drawing;
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
            Icon = Properties.Resources.icono_app;
            Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // el nombre del gimnasio puede ser largo: la etiqueta ocupa todo el ancho del panel y se centra
            lblMarca.AutoSize = false;
            lblMarca.AutoEllipsis = true;
            lblMarca.TextAlign = ContentAlignment.MiddleCenter;
            lblMarca.SetBounds(0, lblMarca.Top, panelIzquierdo.Width, 50);

            MostrarNegocio();
        }

        // nombre y logo del gimnasio desde Configuracion
        private void MostrarNegocio()
        {
            Sesion.CargarNegocio();
            lblMarca.Text = Sesion.NombreNegocio;
            picLogo.Image = Sesion.LogoNegocio(Properties.Resources.icono_logo_login);
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
                MostrarNegocio(); // por si cambiaron la configuracion en esta sesion
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
