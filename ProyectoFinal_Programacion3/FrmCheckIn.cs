using System;
using System.Drawing;
using System.Linq;
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
        VisitaNegocio visitaNegocio = new VisitaNegocio();
        PagoNegocio pagoNegocio = new PagoNegocio();

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

            if (cliente == null)
            {
                // persona nueva: se registra aqui mismo y se vuelve a intentar la entrada
                if (MessageBox.Show("No encontramos la cédula " + cedula + ".\n\n¿Registrar a esta persona como cliente nuevo?", "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                    && new FrmCliente().ShowDialog(this) == DialogResult.OK)
                {
                    RegistrarEntrada();
                    return;
                }

                MostrarResultado("No encontramos esa cédula.", rojo);
                return;
            }

            if (!cliente.Estado)
            {
                MostrarResultado(cliente.NombreCompleto + " · cliente inactivo. Pase por recepción.", rojo);
                return;
            }

            // entro, salio y vuelve: la entrada de hoy ya esta registrada (y cobrada si era visita), pasa sin mas
            if (asistenciaNegocio.YaEntroHoy(cliente.IdCliente))
            {
                MostrarResultado("Bienvenido/a de nuevo, " + cliente.NombreCompleto + " · ya registró su entrada hoy · Puede pasar", verde);
                return;
            }

            var activa = clienteMembresiaNegocio.ObtenerActiva(cliente.IdCliente);

            if (activa == null)
            {
                CargarVisita(cliente);
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

        // sin membresia: se le carga la visita del dia a su cuenta y entra; se cobra despues en pagos
        private void CargarVisita(Cliente cliente)
        {
            var ultima = clienteMembresiaNegocio.ObtenerUltima(cliente.IdCliente);
            var pendientes = visitaNegocio.ListarPendientes(cliente.IdCliente);
            decimal montoVisita = pagoNegocio.ObtenerMontoVisita();

            string situacion = ultima == null
                ? "No tiene membresía."
                : "Su " + ultima.Membresia + " venció el " + ultima.FechaFin.ToString("dd/MM/yyyy") + " (hace " + (DateTime.Today - ultima.FechaFin).Days + " días).";

            string deuda = pendientes.Count == 0
                ? ""
                : "\nYa debe " + pendientes.Count + " visita(s) por RD$" + pendientes.Sum(v => v.Monto).ToString("N2") + ".";

            string pregunta = cliente.NombreCompleto + "\n" + situacion + deuda +
                              "\n\n¿Cargar la visita del día (RD$" + montoVisita.ToString("N2") + ") a su cuenta y registrar la entrada?";

            if (MessageBox.Show(pregunta, "Visita del día", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                MostrarResultado(cliente.NombreCompleto + " · " + situacion + " Pase por recepción.", rojo);
                return;
            }

            string mensaje = visitaNegocio.Cargar(cliente.IdCliente);

            if (mensaje.Length > 0)
            {
                MostrarResultado(cliente.NombreCompleto + " · " + mensaje, rojo);
                return;
            }

            decimal total = pendientes.Sum(v => v.Monto) + montoVisita;
            MostrarResultado("Bienvenido/a, " + cliente.NombreCompleto + " · visita de RD$" + montoVisita.ToString("N2") + " cargada · pendiente RD$" + total.ToString("N2") + " (" + (pendientes.Count + 1) + " visita(s)) · Puede pasar", verde);
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
