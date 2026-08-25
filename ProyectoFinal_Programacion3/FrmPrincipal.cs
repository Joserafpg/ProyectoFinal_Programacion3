using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmPrincipal : Form
    {
        private Form formularioActivo;
        private Button botonActivo;

        // una opcion del menu: el boton, el permiso que exige (tabla permisos) y lo que abre
        private class OpcionMenu
        {
            public Button Boton;
            public string Permiso;
            public EventHandler Abrir;

            public OpcionMenu(Button boton, string permiso, EventHandler abrir)
            {
                Boton = boton;
                Permiso = permiso;
                Abrir = abrir;
            }
        }

        public FrmPrincipal()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            MostrarNegocio();
            AplicarPermisos();
            AbrirPrimeraPantalla();

            if (Sesion.UsuarioActual != null)
            {
                lblUsuarioActual.Text = Sesion.UsuarioActual.NombreCompleto + " · " + Sesion.UsuarioActual.NombreRol;
            }
        }

        // el menu en el mismo orden en que se ve, con el permiso que pide cada opcion
        private OpcionMenu[] OpcionesMenu()
        {
            return new[]
            {
                new OpcionMenu(btnInicio, "REPORTES", btnInicio_Click),
                new OpcionMenu(btnCheckIn, "CLIENTES", btnCheckIn_Click),
                new OpcionMenu(btnPagos, "PAGOS", btnPagos_Click),
                new OpcionMenu(btnPos, "POS", btnPos_Click),
                new OpcionMenu(btnClientes, "CLIENTES", btnClientes_Click),
                new OpcionMenu(btnProductos, "PRODUCTOS", btnProductos_Click),
                new OpcionMenu(btnCompras, "COMPRAS", btnCompras_Click),
                new OpcionMenu(btnSubCategorias, "PRODUCTOS", btnSubCategorias_Click),
                new OpcionMenu(btnSubMarcas, "PRODUCTOS", btnSubMarcas_Click),
                new OpcionMenu(btnMembresias, "MEMBRESIAS", btnMembresias_Click),
                new OpcionMenu(btnSubProveedores, "COMPRAS", btnSubProveedores_Click),
                new OpcionMenu(btnSubEntrenadores, "CLASES", btnSubEntrenadores_Click),
                new OpcionMenu(btnSubHorarios, "CLASES", btnSubHorarios_Click),
                new OpcionMenu(btnSubClases, "CLASES", btnSubClases_Click),
                new OpcionMenu(btnSubUsuarios, "USUARIOS", btnSubUsuarios_Click),
                new OpcionMenu(btnSubConfiguracion, "CONFIGURACION", btnSubConfiguracion_Click)
            };
        }

        // oculta las opciones para las que el rol del usuario no tiene permiso.
        // (se decide con Sesion.Tiene y no con Boton.Visible: antes de mostrar la ventana todos los controles se reportan ocultos)
        private void AplicarPermisos()
        {
            OpcionMenu[] opciones = OpcionesMenu();

            foreach (OpcionMenu opcion in opciones)
            {
                opcion.Boton.Visible = Sesion.Tiene(opcion.Permiso);
            }

            // el grupo Mantenimientos solo se muestra si le queda alguna opcion dentro
            btnMantenimientos.Visible = opciones.Any(o => o.Boton.Parent == panelSubMenu && Sesion.Tiene(o.Permiso));
        }

        // se entra a Inicio; si el rol no puede verlo, a la primera opcion del menu que si pueda
        private void AbrirPrimeraPantalla()
        {
            foreach (OpcionMenu opcion in OpcionesMenu())
            {
                if (!Sesion.Tiene(opcion.Permiso)) continue;

                if (opcion.Boton.Parent == panelSubMenu && !panelSubMenu.Visible)
                {
                    btnMantenimientos_Click(btnMantenimientos, EventArgs.Empty);
                }

                opcion.Abrir(opcion.Boton, EventArgs.Empty);
                return;
            }

            lblTituloPagina.Text = "Sin permisos";
            MessageBox.Show("Su usuario no tiene ningún permiso asignado. Comuníquese con el administrador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // nombre y logo del gimnasio en el menu y en el titulo de la ventana; Configuracion lo llama al guardar
        public void MostrarNegocio()
        {
            string nombre = Sesion.NombreNegocio;
            int ancho = panelLogo.Width - lblLogoMenu.Left - 12;

            Text = nombre;
            lblLogoMenu.AutoSize = false;
            lblLogoMenu.AutoEllipsis = true;
            lblLogoMenu.TextAlign = ContentAlignment.MiddleLeft;
            lblLogoMenu.SetBounds(lblLogoMenu.Left, lblLogoMenu.Top, ancho, 38);

            // si el nombre no cabe con la letra grande se baja un poco
            bool cabe = TextRenderer.MeasureText(nombre, new Font("Segoe UI", 15F, FontStyle.Bold)).Width <= ancho;
            lblLogoMenu.Font = new Font("Segoe UI", cabe ? 15F : 12F, FontStyle.Bold);
            lblLogoMenu.Text = nombre;

            picLogo.Image = Sesion.LogoNegocio(Properties.Resources.icono_logo);
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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCheckIn(), "Check-in", btnCheckIn);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPagos(), "Pagos", btnPagos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmClientes(), "Clientes", btnClientes);
        }

        public void IrAClientes()
        {
            btnClientes.PerformClick();
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMembresias(), "Membresías", btnMembresias);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProductos(), "Productos", btnProductos);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCompras(), "Compras", btnCompras);
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
            AbrirFormulario(new FrmConfiguracion(), "Configuración", btnSubConfiguracion);
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
