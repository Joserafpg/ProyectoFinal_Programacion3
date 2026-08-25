using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmClienteDetalle : Form
    {
        ClienteMembresiaNegocio clienteMembresiaNegocio = new ClienteMembresiaNegocio();
        PagoNegocio pagoNegocio = new PagoNegocio();
        VentaNegocio ventaNegocio = new VentaNegocio();
        Cliente cliente;
        bool huboCambios = false;

        public FrmClienteDetalle()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            Load += FrmClienteDetalle_Load;
            btnEditar.Click += btnEditar_Click;
            btnCobrarMem.Click += btnCobrarMem_Click;
            btnCerrarDet.Click += btnCerrarDet_Click;
            dgvCompras.CellDoubleClick += dgvCompras_CellDoubleClick;
            dgvPagosCliente.CellDoubleClick += dgvPagosCliente_CellDoubleClick;

            // las grillas de aqui son un resumen; el historial completo con filtros esta en sus pantallas
            CrearBoton("Ver todos los pagos").Click += (s, e) => new FrmHistorialPagos(cliente).ShowDialog(this);
            CrearBoton("Ver todas las compras").Click += (s, e) => new FrmVentas(cliente).ShowDialog(this);
        }

        // el boton nuevo queda a la derecha del ultimo de la izquierda
        private Button CrearBoton(string texto)
        {
            var espacio = new Panel { Dock = DockStyle.Left, Width = 10 };
            var boton = new Button { Text = texto, Dock = DockStyle.Left, Width = 165, Font = new Font("Segoe UI", 9.75F), Cursor = Cursors.Hand, UseVisualStyleBackColor = true };

            panelBotones.Controls.Add(espacio);
            panelBotones.Controls.SetChildIndex(espacio, 0);
            panelBotones.Controls.Add(boton);
            panelBotones.Controls.SetChildIndex(boton, 0);
            return boton;
        }

        private void dgvPagosCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Pago pago = (Pago)dgvPagosCliente.Rows[e.RowIndex].DataBoundItem;
            new FrmDetallePago(pago).ShowDialog(this);
        }

        public FrmClienteDetalle(Cliente clienteSeleccionado) : this()
        {
            cliente = clienteSeleccionado;
        }

        private void FrmClienteDetalle_Load(object sender, EventArgs e)
        {
            if (cliente == null) return;

            CargarDatos();
            CargarPagos();
            CargarCompras();
        }

        private void CargarDatos()
        {
            lblNombreDet.Text = cliente.NombreCompleto;
            lblCedulaDet.Text = "Cédula: " + cliente.Cedula + (cliente.Estado ? "" : "   ·   CLIENTE DESACTIVADO");

            if (cliente.Foto != null)
            {
                picFoto.Image = Image.FromStream(new MemoryStream(cliente.Foto));
            }

            var activa = clienteMembresiaNegocio.ObtenerActiva(cliente.IdCliente);

            if (activa != null)
            {
                int diasRestantes = (activa.FechaFin - DateTime.Today).Days;
                lblMembresiaDet.ForeColor = Color.FromArgb(39, 134, 56);
                lblMembresiaDet.Text = "AL DÍA · " + activa.Membresia + " activa · próximo pago el "
                    + activa.FechaFin.AddDays(1).ToString("dd/MM/yyyy") + " (en " + (diasRestantes + 1) + " días)";
            }
            else
            {
                var ultima = clienteMembresiaNegocio.ObtenerUltima(cliente.IdCliente);
                lblMembresiaDet.ForeColor = Color.FromArgb(220, 53, 69);

                if (ultima == null)
                {
                    lblMembresiaDet.Text = "SIN MEMBRESÍA · nunca ha pagado un plan";
                }
                else
                {
                    int diasAtraso = (DateTime.Today - ultima.FechaFin).Days;
                    lblMembresiaDet.Text = "ATRASADO · " + ultima.Membresia + " venció el "
                        + ultima.FechaFin.ToString("dd/MM/yyyy") + " (hace " + diasAtraso + " días) · debe renovar";
                }
            }

            lblDatos1.Text = "Teléfono: " + (string.IsNullOrEmpty(cliente.Telefono) ? "-" : cliente.Telefono)
                + "   ·   Correo: " + (string.IsNullOrEmpty(cliente.Correo) ? "-" : cliente.Correo);
            lblDatos2.Text = "Dirección: " + (string.IsNullOrEmpty(cliente.Direccion) ? "-" : cliente.Direccion);
            lblDatos3.Text = "Sexo: " + (string.IsNullOrEmpty(cliente.Sexo) ? "-" : cliente.Sexo)
                + "   ·   Nacimiento: " + (cliente.FechaNacimiento == null ? "-" : cliente.FechaNacimiento.Value.ToString("dd/MM/yyyy"))
                + "   ·   Registrado el " + cliente.FechaRegistro.ToString("dd/MM/yyyy");
        }

        private void CargarPagos()
        {
            dgvPagosCliente.DataSource = pagoNegocio.ListarPorCliente(cliente.IdCliente);

            string[] visibles = { "Fecha", "Concepto", "MetodoPago", "MontoTotal" };
            foreach (DataGridViewColumn columna in dgvPagosCliente.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvPagosCliente.Columns.Contains("Fecha"))
            {
                dgvPagosCliente.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
            }

            if (dgvPagosCliente.Columns.Contains("MetodoPago"))
            {
                dgvPagosCliente.Columns["MetodoPago"].HeaderText = "Método";
            }

            if (dgvPagosCliente.Columns.Contains("MontoTotal"))
            {
                dgvPagosCliente.Columns["MontoTotal"].HeaderText = "Monto";
                dgvPagosCliente.Columns["MontoTotal"].DefaultCellStyle.Format = "N2";
            }

            dgvPagosCliente.ClearSelection();
        }

        private void CargarCompras()
        {
            dgvCompras.DataSource = ventaNegocio.ListarPorCliente(cliente.IdCliente);

            string[] visibles = { "IdVenta", "Fecha", "TipoPago", "Total", "Estado" };
            foreach (DataGridViewColumn columna in dgvCompras.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvCompras.Columns.Contains("IdVenta"))
            {
                dgvCompras.Columns["IdVenta"].HeaderText = "No.";
            }

            if (dgvCompras.Columns.Contains("Fecha"))
            {
                dgvCompras.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
            }

            if (dgvCompras.Columns.Contains("TipoPago"))
            {
                dgvCompras.Columns["TipoPago"].HeaderText = "Pago";
            }

            if (dgvCompras.Columns.Contains("Total"))
            {
                dgvCompras.Columns["Total"].DefaultCellStyle.Format = "N2";
            }

            dgvCompras.ClearSelection();
        }

        private void dgvCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Venta venta = (Venta)dgvCompras.Rows[e.RowIndex].DataBoundItem;
            new FrmDetalleVenta(venta).ShowDialog(this);
        }

        private void btnCobrarMem_Click(object sender, EventArgs e)
        {
            FrmAsignarMembresia dialogo = new FrmAsignarMembresia(cliente);

            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                huboCambios = true;
                CargarDatos();
                CargarPagos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmCliente dialogo = new FrmCliente(cliente);

            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                huboCambios = true;
                CargarDatos();
            }
        }

        private void btnCerrarDet_Click(object sender, EventArgs e)
        {
            DialogResult = huboCambios ? DialogResult.OK : DialogResult.Cancel;
            Close();
        }
    }
}
