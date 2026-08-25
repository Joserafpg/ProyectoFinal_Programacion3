using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmConfiguracion : Form
    {
        const int TamanoMaximoLogo = 2 * 1024 * 1024;

        ConfiguracionNegocio configuracionNegocio = new ConfiguracionNegocio();
        Configuracion configuracion = null;
        byte[] logo = null;

        public FrmConfiguracion()
        {
            InitializeComponent();
            Load += FrmConfiguracion_Load;
            txtRnc.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtTelefono.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtImpuesto.KeyPress += Validaciones.SoloDecimales;
            txtMontoVisita.KeyPress += Validaciones.SoloDecimales;
            btnGuardar.Click += btnGuardar_Click;
            btnCargarLogo.Click += btnCargarLogo_Click;
            btnQuitarLogo.Click += btnQuitarLogo_Click;
            btnFacturaEjemplo.Click += btnFacturaEjemplo_Click;
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            configuracion = configuracionNegocio.Obtener();

            if (configuracion == null)
            {
                MessageBox.Show("No se encontró la configuración en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtNombreGimnasio.Text = configuracion.NombreGimnasio;
            txtRnc.Text = configuracion.Rnc;
            txtTelefono.Text = configuracion.Telefono;
            txtCorreo.Text = configuracion.Correo;
            txtDireccion.Text = configuracion.Direccion;
            txtImpuesto.Text = configuracion.PorcentajeImpuesto.ToString();
            txtMontoVisita.Text = configuracion.MontoVisita.ToString();
            txtMensajeRecibo.Text = configuracion.MensajeRecibo;
            logo = configuracion.Logo;
            MostrarLogo();
        }

        private void MostrarLogo()
        {
            picLogoConf.Image = Sesion.ImagenDesdeBytes(logo, null);
            btnQuitarLogo.Enabled = logo != null;
        }

        private void btnCargarLogo_Click(object sender, EventArgs e)
        {
            using (var buscador = new OpenFileDialog { Title = "Seleccionar logo", Filter = "Imágenes|*.png;*.jpg;*.jpeg" })
            {
                if (buscador.ShowDialog(this) != DialogResult.OK) return;

                byte[] bytes = File.ReadAllBytes(buscador.FileName);

                if (bytes.Length > TamanoMaximoLogo)
                {
                    MessageBox.Show("El logo no puede pesar más de 2 MB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Sesion.ImagenDesdeBytes(bytes, null) == null)
                {
                    MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                logo = bytes;
                MostrarLogo();
            }
        }

        private void btnQuitarLogo_Click(object sender, EventArgs e)
        {
            logo = null;
            MostrarLogo();
        }

        // arma la configuracion con lo que hay en pantalla (sin guardarla); null si algun valor no es valido
        private Configuracion LeerPantalla()
        {
            if (!decimal.TryParse(txtImpuesto.Text, out decimal impuesto))
            {
                MessageBox.Show("El porcentaje de impuesto debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!decimal.TryParse(txtMontoVisita.Text, out decimal montoVisita))
            {
                MessageBox.Show("El monto de la visita debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new Configuracion
            {
                IdConfiguracion = 1,
                NombreGimnasio = txtNombreGimnasio.Text.Trim(),
                Rnc = txtRnc.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                PorcentajeImpuesto = impuesto,
                MontoVisita = montoVisita,
                MensajeRecibo = txtMensajeRecibo.Text.Trim(),
                Logo = logo
            };
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (configuracion == null) return;

            Configuracion nueva = LeerPantalla();
            if (nueva == null) return;

            string mensaje = configuracionNegocio.Actualizar(nueva);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            configuracion = nueva;

            // el resto de la aplicacion (menu, titulo, facturas) usa los datos nuevos de inmediato
            Sesion.Negocio = nueva;
            FrmPrincipal principal = FindForm() as FrmPrincipal;
            if (principal != null)
            {
                principal.MostrarNegocio();
            }

            MessageBox.Show("Configuración guardada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // muestra como quedaria la factura con los datos de la pantalla, aunque no se hayan guardado
        private void btnFacturaEjemplo_Click(object sender, EventArgs e)
        {
            Configuracion temporal = LeerPantalla();
            if (temporal == null) return;

            new FrmFactura(VentaEjemplo(temporal.PorcentajeImpuesto), temporal).ShowDialog(this);
        }

        private static Venta VentaEjemplo(decimal porcentajeImpuesto)
        {
            var detalles = new List<VentaDetalle>
            {
                new VentaDetalle { Producto = "Proteína Whey 5 lb", Cantidad = 1, Precio = 3500, Subtotal = 3500 },
                new VentaDetalle { Producto = "Agua 500ml", Cantidad = 2, Precio = 50, Subtotal = 100 },
                new VentaDetalle { Producto = "Guantes de entrenamiento", Cantidad = 1, Precio = 1200, Subtotal = 1200 }
            };

            decimal subtotal = 4800;
            decimal impuesto = Math.Round(subtotal * porcentajeImpuesto / 100, 2);

            return new Venta
            {
                IdVenta = 1,
                Fecha = DateTime.Now,
                Cliente = "Cliente de ejemplo",
                CedulaCliente = "000-0000000-0",
                Usuario = Sesion.UsuarioActual == null ? "Vendedor" : Sesion.UsuarioActual.NombreCompleto,
                TipoPago = "Contado",
                Estado = "Completada",
                Subtotal = subtotal,
                Impuesto = impuesto,
                Total = subtotal + impuesto,
                Detalles = detalles
            };
        }
    }
}
