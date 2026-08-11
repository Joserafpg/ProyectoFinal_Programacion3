using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmPrincipal : Form
    {
        private Form formularioActivo;
        private Button botonActivo;

        public FrmPrincipal()
        {
            InitializeComponent();
            AbrirFormulario(new FrmInicio(), "Inicio", btnInicio);

            if (Sesion.UsuarioActual != null)
            {
                lblUsuarioActual.Text = Sesion.UsuarioActual.NombreCompleto + " · " + Sesion.UsuarioActual.NombreRol;
            }
        }

        private void AbrirFormulario(Form formulario, string titulo, Button boton)
        {
            CerrarFormularioActivo();
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
            lblTituloPagina.Text = titulo;
            ResaltarBoton(boton);
        }

        private void CerrarFormularioActivo()
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }
        }

        private void ResaltarBoton(Button boton)
        {
            if (botonActivo != null)
            {
                botonActivo.BackColor = Color.White;
                botonActivo.Font = new Font("Segoe UI", botonActivo.Parent == panelSubMenu ? 10F : 10.5F);
                botonActivo.ForeColor = botonActivo.Parent == panelSubMenu
                    ? Color.FromArgb(130, 135, 158)
                    : Color.FromArgb(71, 75, 100);
            }
            boton.BackColor = Color.FromArgb(253, 230, 138);
            boton.Font = new Font("Segoe UI", boton.Parent == panelSubMenu ? 10F : 10.5F, FontStyle.Bold);
            boton.ForeColor = Color.FromArgb(74, 63, 22);
            botonActivo = boton;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInicio(), "Inicio", btnInicio);
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPos(), "Punto de venta", btnPos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmClientes(), "Clientes", btnClientes);
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMembresias(), "Membresías", btnMembresias);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProductos(), "Productos", btnProductos);
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = !panelSubMenu.Visible;
            btnMantenimientos.Text = panelSubMenu.Visible ? "Mantenimientos   ▴" : "Mantenimientos   ▾";
        }

        private void btnSubCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCategorias(), "Categorías", btnSubCategorias);
        }

        private void btnSubMarcas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMarcas(), "Marcas", btnSubMarcas);
        }

        private void btnSubProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProveedores(), "Proveedores", btnSubProveedores);
        }

        private void btnSubEntrenadores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEntrenadores(), "Entrenadores", btnSubEntrenadores);
        }

        private void btnSubHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHorarios(), "Horarios", btnSubHorarios);
        }

        private void btnSubClases_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmClases(), "Clases", btnSubClases);
        }

        private void btnSubUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios(), "Usuarios", btnSubUsuarios);
        }

        private void btnSubConfiguracion_Click(object sender, EventArgs e)
        {
            // modulo de configuracion pendiente
            CerrarFormularioActivo();
            lblTituloPagina.Text = "Configuración";
            ResaltarBoton(btnSubConfiguracion);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
