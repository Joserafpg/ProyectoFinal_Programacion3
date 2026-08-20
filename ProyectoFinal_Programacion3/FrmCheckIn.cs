using System;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCheckIn : Form
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        ClienteMembresiaNegocio clienteMembresiaNegocio = new ClienteMembresiaNegocio();
        AsistenciaNegocio asistenciaNegocio = new AsistenciaNegocio();

        Color verde = Color.FromArgb(39, 134, 56);
        Color rojo = Color.FromArgb(220, 53, 69);

        public FrmCheckIn()
        {
            InitializeComponent();
            Load += FrmCheckIn_Load;
            txtCedula.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtCedula.KeyDown += txtCedula_KeyDown;
            txtCedula.TextChanged += txtCedula_TextChanged;
            btnRegistrar.Click += btnRegistrar_Click;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            timerLimpiar.Tick += timerLimpiar_Tick;
        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            txtCedula.Focus();
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                RegistrarEntrada();
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            timerLimpiar.Stop();
            lblResultado.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarEntrada();
        }

        // por si la persona no se sabe la cedula: se busca por nombre y se registra igual
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente buscador = new FrmBuscarCliente();
            buscador.SinConsumidorFinal = true;

            if (buscador.ShowDialog(this) == DialogResult.OK && buscador.ClienteSeleccionado != null)
            {
                txtCedula.Text = buscador.ClienteSeleccionado.Cedula;
                RegistrarEntrada();
            }
        }

        private void RegistrarEntrada()
        {
            string cedula = txtCedula.Text.Trim();

            if (cedula.Length == 0)
            {
                MostrarResultado("Escriba su cédula.", rojo);
                return;
            }

            Cliente cliente = clienteNegocio.ObtenerPorCedula(cedula);

            if (cliente == null || !cliente.Estado)
            {
                MostrarResultado("No encontramos esa cédula. Pase por recepción.", rojo);
                return;
            }

            var activa = clienteMembresiaNegocio.ObtenerActiva(cliente.IdCliente);

            if (activa == null)
            {
                var ultima = clienteMembresiaNegocio.ObtenerUltima(cliente.IdCliente);

                if (ultima == null)
                {
                    MostrarResultado(cliente.NombreCompleto + " · no tiene membresía. Pase por recepción.", rojo);
                }
                else
                {
                    int dias = (DateTime.Today - ultima.FechaFin).Days;
                    MostrarResultado(cliente.NombreCompleto + " · su " + ultima.Membresia + " venció el " + ultima.FechaFin.ToString("dd/MM/yyyy") + " (hace " + dias + " días). Pase por recepción.", rojo);
                }

                return;
            }

            string confirmacion = cliente.NombreCompleto + "\n" + activa.Membresia + " · vence el " + activa.FechaFin.ToString("dd/MM/yyyy") + "\n\n¿Registrar la entrada?";

            if (MessageBox.Show(confirmacion, "Confirmar entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                txtCedula.Clear();
                txtCedula.Focus();
                return;
            }

            string mensaje = asistenciaNegocio.RegistrarEntrada(cliente.IdCliente);

            if (mensaje.Length > 0)
            {
                MostrarResultado(cliente.NombreCompleto + " · " + mensaje, rojo);
                return;
            }

            MessageBox.Show("Entrada confirmada.\n\n¡Bienvenido/a, " + cliente.NombreCompleto + "! Puede pasar.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarResultado("Bienvenido/a, " + cliente.NombreCompleto + " · " + activa.Membresia + " vence el " + activa.FechaFin.ToString("dd/MM/yyyy") + " · Puede pasar", verde);
        }

        // muestra el mensaje y en unos segundos limpia todo para la siguiente persona
        private void MostrarResultado(string texto, Color color)
        {
            timerLimpiar.Stop();
            lblResultado.Text = texto;
            lblResultado.ForeColor = color;
            txtCedula.SelectAll();
            txtCedula.Focus();
            timerLimpiar.Start();
        }

        private void timerLimpiar_Tick(object sender, EventArgs e)
        {
            timerLimpiar.Stop();
            txtCedula.Clear();
            lblResultado.Text = "";
            txtCedula.Focus();
        }
    }
}
