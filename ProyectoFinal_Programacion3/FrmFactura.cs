using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    // vista previa de la factura de una venta. se usa de tres formas:
    //  - ver e imprimir una venta ya registrada (historial, detalle)
    //  - confirmar una venta desde el POS: se registra al confirmar y despues se puede imprimir
    //  - factura de ejemplo desde Configuracion, con datos que todavia no se han guardado
    public partial class FrmFactura : Form
    {
        Venta venta;
        Configuracion negocio;
        bool confirmar;
        bool ejemplo;
        PrintDocument documento;
        VentaNegocio ventaNegocio = new VentaNegocio();

        // numero de la venta que se registro al confirmar; 0 si se cancelo
        public int IdVentaRegistrada { get; private set; }

        public FrmFactura()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            Load += FrmFactura_Load;
            FormClosed += FrmFactura_FormClosed;
            btnPrincipal.Click += btnPrincipal_Click;
            btnSecundario.Click += btnSecundario_Click;
        }

        // ver e imprimir una venta registrada
        public FrmFactura(Venta ventaSeleccionada) : this()
        {
            venta = ventaSeleccionada;
        }

        // vista previa antes de cobrar: la venta se registra cuando el usuario confirma
        public FrmFactura(Venta ventaPendiente, bool confirmarVenta) : this(ventaPendiente)
        {
            confirmar = confirmarVenta;
        }

        // factura de ejemplo con una configuracion sin guardar
        public FrmFactura(Venta ventaEjemplo, Configuracion configuracion) : this(ventaEjemplo)
        {
            negocio = configuracion;
            ejemplo = true;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            if (venta == null)
            {
                BeginInvoke(new Action(Close));
                return;
            }

            if (venta.Detalles == null)
            {
                venta.Detalles = ventaNegocio.ListarDetalle(venta.IdVenta);
            }

            // la configuracion cargada en la sesion (se refresca al guardar en Configuracion), o la de la base de datos
            if (negocio == null)
            {
                negocio = Sesion.Negocio ?? new ConfiguracionNegocio().Obtener();
            }

            if (confirmar)
            {
                ModoConfirmar();
            }
            else
            {
                ModoVer();
            }

            if (!Renderizar())
            {
                BeginInvoke(new Action(Close));
            }
        }

        // arma el documento con la venta actual y lo muestra; false si no hay ninguna impresora
        private bool Renderizar()
        {
            if (documento != null)
            {
                documento.Dispose();
            }

            documento = new Factura(venta, negocio).CrearDocumento();

            try
            {
                vistaPrevia.Document = documento;
                return true;
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("No hay ninguna impresora instalada en este equipo. Instale una impresora (o \"Microsoft Print to PDF\") para ver e imprimir facturas.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void ModoConfirmar()
        {
            Text = "Confirmar venta";
            lblEstado.Text = "Vista previa · la venta todavía no se ha registrado";
            btnPrincipal.Text = "CONFIRMAR E IMPRIMIR";
            btnSecundario.Text = "Confirmar sin imprimir";
            btnSecundario.Visible = true;
            spSecundario.Visible = true;
            btnCerrar.Text = "Cancelar";
        }

        private void ModoVer()
        {
            Text = ejemplo ? "Factura de ejemplo" : "Factura No. " + venta.NumeroFactura;
            lblEstado.Text = ejemplo
                ? "Factura de ejemplo con la configuración actual (sin guardar)"
                : "Factura No. " + venta.NumeroFactura + " · " + venta.Cliente;
            btnPrincipal.Text = "IMPRIMIR";
            btnSecundario.Visible = false;
            spSecundario.Visible = false;
            btnCerrar.Text = "Cerrar";
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            if (confirmar && !Confirmar()) return;

            Imprimir();
        }

        private void btnSecundario_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        // registra la venta, la recarga con su numero y pasa la ventana a modo ver/imprimir
        private bool Confirmar()
        {
            string mensaje = ventaNegocio.Insertar(venta, out int idVenta);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            IdVentaRegistrada = idVenta;
            confirmar = false;

            Venta registrada = ventaNegocio.ObtenerPorId(idVenta);

            if (registrada != null)
            {
                venta = registrada;
            }
            else
            {
                venta.IdVenta = idVenta;
            }

            ModoVer();
            lblEstado.Text = "Venta No. " + venta.NumeroFactura + " registrada · Total: RD$" + venta.Total.ToString("N2");
            Renderizar();
            return true;
        }

        private void Imprimir()
        {
            using (var dialogo = new PrintDialog { Document = documento, UseEXDialog = true, AllowSomePages = false })
            {
                if (dialogo.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    documento.Print();
                    lblEstado.Text = "Factura No. " + venta.NumeroFactura + " enviada a " + documento.PrinterSettings.PrinterName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo imprimir la factura: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (documento != null)
            {
                documento.Dispose();
            }
        }
    }
}
