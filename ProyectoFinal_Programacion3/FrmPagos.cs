using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmPagos : Form
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        ClienteMembresiaNegocio clienteMembresiaNegocio = new ClienteMembresiaNegocio();
        CuentaCobrarNegocio cuentaCobrarNegocio = new CuentaCobrarNegocio();
        PagoNegocio pagoNegocio = new PagoNegocio();
        MembresiaNegocio membresiaNegocio = new MembresiaNegocio();

        Cliente cliente = null;

        Color verde = Color.FromArgb(39, 134, 56);
        Color rojo = Color.FromArgb(220, 53, 69);
        Color gris = Color.FromArgb(130, 135, 158);

        public FrmPagos()
        {
            InitializeComponent();
            Load += FrmPagos_Load;
            btnBuscarCli.Click += btnBuscarCli_Click;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            cboDetalle.SelectedIndexChanged += cboDetalle_SelectedIndexChanged;
            txtMonto.KeyPress += Validaciones.SoloDecimales;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            dgvMorosos.CellDoubleClick += dgvMorosos_CellDoubleClick;
            dgvCreditos.CellDoubleClick += dgvCreditos_CellDoubleClick;
            dgvPagos.DataBindingComplete += dgv_DataBindingComplete;
            dgvMorosos.DataBindingComplete += dgv_DataBindingComplete;
            dgvCreditos.DataBindingComplete += dgv_DataBindingComplete;
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            cboMetodo.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;
            MostrarCliente(null);
            CargarMorosos();
            CargarCreditos();
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
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

        private void MostrarCliente(Cliente seleccionado)
        {
            cliente = seleccionado;

            if (cliente == null)
            {
                lblCliente.Text = "Ningún cliente seleccionado";
                lblEstadoCli.Text = "Busque un cliente para cobrar membresías o abonos a crédito. La visita del día no necesita cliente.";
                lblEstadoCli.ForeColor = gris;
            }
            else
            {
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

            CargarDetalle();
            CargarPagos();
        }

        // ---------- registrar pago ----------

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDetalle();
        }

        private void cboDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarInfo();
        }

        // llena el segundo combo segun el tipo: planes o cuentas pendientes
        private void CargarDetalle()
        {
            string tipo = cboTipo.Text;

            if (tipo == "Membresía")
            {
                lblDetalle.Text = "Plan:";
                cboDetalle.Enabled = true;
                cboDetalle.DataSource = membresiaNegocio.Listar().Where(m => m.Estado).ToList();
                cboDetalle.DisplayMember = "Nombre";
                txtMonto.ReadOnly = true;
            }
            else if (tipo == "Abono a crédito")
            {
                lblDetalle.Text = "Cuenta:";
                cboDetalle.Enabled = true;
                cboDetalle.DataSource = cliente == null ? null : cuentaCobrarNegocio.ListarPorCliente(cliente.IdCliente);
                cboDetalle.DisplayMember = "Descripcion";
                txtMonto.ReadOnly = false;
            }
            else
            {
                lblDetalle.Text = "";
                cboDetalle.DataSource = null;
                cboDetalle.Enabled = false;
                txtMonto.ReadOnly = true;
            }

            ActualizarInfo();
        }

        private void ActualizarInfo()
        {
            string tipo = cboTipo.Text;

            if (tipo == "Membresía")
            {
                Membresia plan = cboDetalle.SelectedItem as Membresia;

                if (plan == null)
                {
                    txtMonto.Text = "";
                    lblInfoPago.Text = "No hay planes de membresía activos.";
                    btnRegistrarPago.Text = "Cobrar";
                    return;
                }

                txtMonto.Text = plan.Precio.ToString("N2");
                btnRegistrarPago.Text = "Cobrar RD$" + plan.Precio.ToString("N2");

                if (cliente == null)
                {
                    lblInfoPago.Text = "Seleccione un cliente para cobrarle la membresía.";
                    return;
                }

                DateTime inicio = DateTime.Today;
                var activa = clienteMembresiaNegocio.ObtenerActiva(cliente.IdCliente);
                if (activa != null)
                    inicio = activa.FechaFin.AddDays(1);

                DateTime fin = inicio.AddDays(plan.DuracionDias - 1);
                lblInfoPago.Text = "Vigencia: del " + inicio.ToString("dd/MM/yyyy") + " al " + fin.ToString("dd/MM/yyyy") + " (" + plan.DuracionDias + " días)"
                    + (activa != null ? " · arranca cuando venza la actual" : "");
            }
            else if (tipo == "Abono a crédito")
            {
                CuentaCobrar cuenta = cboDetalle.SelectedItem as CuentaCobrar;
                btnRegistrarPago.Text = "Abonar";

                if (cliente == null)
                {
                    txtMonto.Text = "";
                    lblInfoPago.Text = "Seleccione un cliente para ver sus créditos pendientes.";
                    return;
                }

                if (cuenta == null)
                {
                    txtMonto.Text = "";
                    lblInfoPago.Text = "Este cliente no tiene créditos pendientes.";
                    return;
                }

                txtMonto.Text = cuenta.Saldo.ToString("N2");
                lblInfoPago.Text = "Venta #" + cuenta.IdVenta + " del " + cuenta.FechaVenta.ToString("dd/MM/yyyy")
                    + " · monto original RD$" + cuenta.MontoOriginal.ToString("N2")
                    + " · saldo RD$" + cuenta.Saldo.ToString("N2")
                    + " · vence el " + cuenta.FechaVencimiento.ToString("dd/MM/yyyy")
                    + " · puede abonar una parte o saldar completo";
            }
            else
            {
                decimal montoVisita = pagoNegocio.ObtenerMontoVisita();
                txtMonto.Text = montoVisita.ToString("N2");
                btnRegistrarPago.Text = "Cobrar RD$" + montoVisita.ToString("N2");
                lblInfoPago.Text = cliente == null
                    ? "Visita del día · se registra como visitante y queda con acceso por hoy"
                    : "Visita del día · se registra a nombre de " + cliente.NombreCompleto + " y queda con acceso por hoy";
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("Debe iniciar sesión para cobrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Sesion.UsuarioActual.IdUsuario;
            string metodo = cboMetodo.Text;
            string tipo = cboTipo.Text;
            string mensaje;

            if (tipo == "Membresía")
            {
                mensaje = clienteMembresiaNegocio.Asignar(cliente, cboDetalle.SelectedItem as Membresia, metodo, idUsuario);
            }
            else if (tipo == "Abono a crédito")
            {
                if (!decimal.TryParse(txtMonto.Text, out decimal monto))
                {
                    MessageBox.Show("El monto no es válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                mensaje = cuentaCobrarNegocio.Abonar(cboDetalle.SelectedItem as CuentaCobrar, monto, metodo, idUsuario);
            }
            else
            {
                mensaje = pagoNegocio.CobrarVisita(metodo, idUsuario, cliente);
            }

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Pago registrado con éxito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarCliente(cliente);
            CargarMorosos();
            CargarCreditos();
        }

        // ---------- tablas ----------

        private void CargarPagos()
        {
            if (cliente == null)
            {
                dgvPagos.DataSource = pagoNegocio.Listar();
                tabPagos.Text = "Todos los pagos";
            }
            else
            {
                dgvPagos.DataSource = pagoNegocio.ListarPorCliente(cliente.IdCliente);
                tabPagos.Text = "Pagos de " + cliente.Nombre;
            }

            string[] visibles = { "Fecha", "Cliente", "Concepto", "MetodoPago", "MontoTotal", "Usuario" };
            foreach (DataGridViewColumn columna in dgvPagos.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvPagos.Columns.Contains("Fecha"))
            {
                dgvPagos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                dgvPagos.Columns["Concepto"].FillWeight = 180;
                dgvPagos.Columns["MetodoPago"].HeaderText = "Método";
                dgvPagos.Columns["MontoTotal"].HeaderText = "Monto";
                dgvPagos.Columns["MontoTotal"].DefaultCellStyle.Format = "N2";
                dgvPagos.Columns["Usuario"].HeaderText = "Cobrado por";
            }
        }

        private void CargarMorosos()
        {
            dgvMorosos.DataSource = clienteMembresiaNegocio.ListarVencidas();

            string[] visibles = { "Cliente", "Cedula", "Membresia", "FechaFin" };
            foreach (DataGridViewColumn columna in dgvMorosos.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvMorosos.Columns.Contains("Cedula"))
            {
                dgvMorosos.Columns["Cedula"].HeaderText = "Cédula";
                dgvMorosos.Columns["Membresia"].HeaderText = "Último plan";
                dgvMorosos.Columns["FechaFin"].HeaderText = "Venció el";
                dgvMorosos.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            tabMorosos.Text = "Deben renovar (" + dgvMorosos.Rows.Count + ")";
        }

        private void CargarCreditos()
        {
            dgvCreditos.DataSource = cuentaCobrarNegocio.ListarPendientes();

            string[] visibles = { "Cliente", "Cedula", "IdVenta", "FechaVenta", "MontoOriginal", "Saldo", "FechaVencimiento" };
            foreach (DataGridViewColumn columna in dgvCreditos.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvCreditos.Columns.Contains("Cedula"))
            {
                dgvCreditos.Columns["Cedula"].HeaderText = "Cédula";
                dgvCreditos.Columns["IdVenta"].HeaderText = "Venta #";
                dgvCreditos.Columns["FechaVenta"].HeaderText = "Fecha";
                dgvCreditos.Columns["FechaVenta"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvCreditos.Columns["MontoOriginal"].HeaderText = "Monto original";
                dgvCreditos.Columns["MontoOriginal"].DefaultCellStyle.Format = "N2";
                dgvCreditos.Columns["Saldo"].DefaultCellStyle.Format = "N2";
                dgvCreditos.Columns["FechaVencimiento"].HeaderText = "Vence el";
                dgvCreditos.Columns["FechaVencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            tabCreditos.Text = "Créditos pendientes (" + dgvCreditos.Rows.Count + ")";
        }

        // doble click en un moroso: lo selecciona y deja listo el cobro de membresía
        private void dgvMorosos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ClienteMembresia vencida = (ClienteMembresia)dgvMorosos.Rows[e.RowIndex].DataBoundItem;
            Cliente encontrado = clienteNegocio.ObtenerPorCedula(vencida.Cedula);
            if (encontrado == null) return;

            cboTipo.SelectedIndex = 0;
            MostrarCliente(encontrado);
        }

        // doble click en un credito: lo selecciona y deja lista esa cuenta para abonar
        private void dgvCreditos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            CuentaCobrar cuenta = (CuentaCobrar)dgvCreditos.Rows[e.RowIndex].DataBoundItem;
            Cliente encontrado = clienteNegocio.ObtenerPorCedula(cuenta.Cedula);
            if (encontrado == null) return;

            cboTipo.SelectedIndex = 1;
            MostrarCliente(encontrado);

            foreach (CuentaCobrar item in cboDetalle.Items)
            {
                if (item.IdCuenta == cuenta.IdCuenta)
                {
                    cboDetalle.SelectedItem = item;
                    break;
                }
            }
        }
    }
}
