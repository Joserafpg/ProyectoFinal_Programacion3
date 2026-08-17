using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmConfiguracion : Form
    {
        ConfiguracionNegocio configuracionNegocio = new ConfiguracionNegocio();
        Configuracion configuracion = null;

        public FrmConfiguracion()
        {
            InitializeComponent();
            Load += FrmConfiguracion_Load;
            txtRnc.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtTelefono.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtImpuesto.KeyPress += Validaciones.SoloDecimales;
            txtMontoVisita.KeyPress += Validaciones.SoloDecimales;
            btnGuardar.Click += btnGuardar_Click;
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (configuracion == null) return;

            if (!decimal.TryParse(txtImpuesto.Text, out decimal impuesto))
            {
                MessageBox.Show("El porcentaje de impuesto debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMontoVisita.Text, out decimal montoVisita))
            {
                MessageBox.Show("El monto de la visita debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            configuracion.NombreGimnasio = txtNombreGimnasio.Text;
            configuracion.Rnc = txtRnc.Text;
            configuracion.Telefono = txtTelefono.Text;
            configuracion.Correo = txtCorreo.Text;
            configuracion.Direccion = txtDireccion.Text;
            configuracion.PorcentajeImpuesto = impuesto;
            configuracion.MontoVisita = montoVisita;
            configuracion.MensajeRecibo = txtMensajeRecibo.Text;

            string mensaje = configuracionNegocio.Actualizar(configuracion);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Configuración guardada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
