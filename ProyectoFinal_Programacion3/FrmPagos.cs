using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmPagos : Form
    {
        ClienteMembresiaNegocio clienteMembresiaNegocio = new ClienteMembresiaNegocio();
        CuentaCobrarNegocio cuentaCobrarNegocio = new CuentaCobrarNegocio();
        PagoNegocio pagoNegocio = new PagoNegocio();

        Cliente cliente = null;
        BindingList<PagoPendiente> carrito = new BindingList<PagoPendiente>();

        Color verde = Color.FromArgb(39, 134, 56);
        Color rojo = Color.FromArgb(220, 53, 69);
        Color gris = Color.FromArgb(130, 135, 158);

        public FrmPagos()
        {
            InitializeComponent();
            Load += FrmPagos_Load;
            btnBuscarCli.Click += btnBuscarCli_Click;
            btnHistorial.Click += btnHistorial_Click;
            btnAgregarPago.Click += btnAgregarPago_Click;
            btnQuitarPago.Click += btnQuitarPago_Click;
            btnCobrar.Click += btnCobrar_Click;
            dgvCarrito.DataBindingComplete += dgvCarrito_DataBindingComplete;
            dgvCarrito.CellBeginEdit += dgvCarrito_CellBeginEdit;
            dgvCarrito.CellEndEdit += dgvCarrito_CellEndEdit;
            dgvCarrito.DataError += dgvCarrito_DataError;
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            cboMetodo.SelectedIndex = 0;
            dgvCarrito.DataSource = carrito;
            MostrarCliente(null);
        }

        // ---------- cliente ----------

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente buscador = new FrmBuscarCliente();
            buscador.SinConsumidorFinal = true;

            if (buscador.ShowDialog(this) == DialogResult.OK && buscador.ClienteSeleccionado != null)
            {
                MostrarCliente(buscador.ClienteSeleccionado);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorialPagos historial = new FrmHistorialPagos(cliente);

            if (historial.ShowDialog(this) == DialogResult.OK && historial.ClienteSeleccionado != null)
            {
                MostrarCliente(historial.ClienteSeleccionado);
                btnAgregarPago.PerformClick();
            }
        }

        private void MostrarCliente(Cliente seleccionado)
        {
            cliente = seleccionado;
            carrito.Clear();
            ActualizarTotal();
            btnAgregarPago.Enabled = cliente != null;

            if (cliente == null)
            {
                lblCliente.Text = "Ningún cliente seleccionado";
                lblEstadoCli.Text = "Busque un cliente para ver lo que tiene pendiente y armar su pago.";
                lblEstadoCli.ForeColor = gris;
                return;
            }

            lblCliente.Text = cliente.NombreCompleto + " · " + cliente.Cedula;

            string textoMembresia;
            var activa = clienteMembresiaNegocio.ObtenerActiva(cliente.IdCliente);

            if (activa != null)
            {
                textoMembresia = "Membresía: AL DÍA · " + activa.Membresia + " vence el " + activa.FechaFin.ToString("dd/MM/yyyy");
            }
            else
            {
                var ultima = clienteMembresiaNegocio.ObtenerUltima(cliente.IdCliente);
                textoMembresia = ultima == null
                    ? "Membresía: SIN MEMBRESÍA"
                    : "Membresía: ATRASADO · " + ultima.Membresia + " venció el " + ultima.FechaFin.ToString("dd/MM/yyyy") + " (hace " + (DateTime.Today - ultima.FechaFin).Days + " días)";
            }

            decimal deuda = cuentaCobrarNegocio.ObtenerDeuda(cliente.IdCliente);
            string textoCredito = deuda > 0 ? "Crédito: debe RD$" + deuda.ToString("N2") : "Crédito: sin deuda";

            lblEstadoCli.Text = textoMembresia + "   |   " + textoCredito;
            lblEstadoCli.ForeColor = (activa != null && deuda == 0) ? verde : rojo;
        }

        // ---------- carrito ----------

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            FrmAgregarPago dialogo = new FrmAgregarPago(cliente, carrito.Select(c => c.Concepto).ToList());
            dialogo.ShowDialog(this);

            foreach (var item in dialogo.Agregados)
            {
                carrito.Add(item);
            }

            ActualizarTotal();
        }

        private void btnQuitarPago_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el pago que quiere quitar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            carrito.Remove((PagoPendiente)dgvCarrito.CurrentRow.DataBoundItem);
            ActualizarTotal();
        }

        private void dgvCarrito_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvCarrito, "Tipo", "Concepto", "Monto");

            if (dgvCarrito.Columns.Contains("Monto"))
            {
                dgvCarrito.Columns["Tipo"].FillWeight = 60;
                dgvCarrito.Columns["Tipo"].ReadOnly = true;
                dgvCarrito.Columns["Concepto"].FillWeight = 200;
                dgvCarrito.Columns["Concepto"].ReadOnly = true;
                dgvCarrito.Columns["Monto"].FillWeight = 60;
                dgvCarrito.Columns["Monto"].DefaultCellStyle.Format = "N2";
            }

            dgvCarrito.ClearSelection();
            dgvCarrito.CurrentCell = null;
        }

        // el monto solo se puede editar en los abonos a credito
        private void dgvCarrito_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            PagoPendiente item = (PagoPendiente)dgvCarrito.Rows[e.RowIndex].DataBoundItem;

            if (item.Cuenta == null)
            {
                e.Cancel = true;
            }
        }

        private void dgvCarrito_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PagoPendiente item = (PagoPendiente)dgvCarrito.Rows[e.RowIndex].DataBoundItem;

            if (item.Cuenta != null && (item.Monto <= 0 || item.Monto > item.Cuenta.Saldo))
            {
                item.Monto = item.Cuenta.Saldo;
                carrito.ResetBindings();
            }

            ActualizarTotal();
        }

        private void dgvCarrito_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("El monto no es válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = false;
        }

        private void ActualizarTotal()
        {
            decimal total = carrito.Sum(c => c.Monto);
            lblTotal.Text = "Total: RD$" + total.ToString("N2") + (carrito.Count > 0 ? "   (" + carrito.Count + " pagos)" : "");
            btnCobrar.Text = carrito.Count > 0 ? "Cobrar RD$" + total.ToString("N2") : "Cobrar";
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("Debe iniciar sesión para cobrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = pagoNegocio.CobrarPendientes(cliente, carrito.ToList(), cboMetodo.Text, Sesion.UsuarioActual.IdUsuario);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Pago registrado con éxito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarCliente(cliente);
        }
    }
}
