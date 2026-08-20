using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmHistorialPagos : Form
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        ClienteMembresiaNegocio clienteMembresiaNegocio = new ClienteMembresiaNegocio();
        CuentaCobrarNegocio cuentaCobrarNegocio = new CuentaCobrarNegocio();
        PagoNegocio pagoNegocio = new PagoNegocio();

        Cliente cliente = null;

        // si el usuario da doble click a un moroso o credito, aqui queda el cliente para cobrarle
        public Cliente ClienteSeleccionado = null;

        public FrmHistorialPagos()
        {
            InitializeComponent();
            Load += FrmHistorialPagos_Load;
            dgvMorosos.CellDoubleClick += dgvMorosos_CellDoubleClick;
            dgvCreditos.CellDoubleClick += dgvCreditos_CellDoubleClick;
            dgvPagos.DataBindingComplete += dgv_DataBindingComplete;
            dgvMorosos.DataBindingComplete += dgv_DataBindingComplete;
            dgvCreditos.DataBindingComplete += dgv_DataBindingComplete;
        }

        public FrmHistorialPagos(Cliente clienteActual) : this()
        {
            cliente = clienteActual;
        }

        private void FrmHistorialPagos_Load(object sender, EventArgs e)
        {
            CargarPagos();
            CargarMorosos();
            CargarCreditos();
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void CargarPagos()
        {
            if (cliente == null)
            {
                dgvPagos.DataSource = pagoNegocio.Listar();
                tabPagos.Text = "Todos los pagos";
                Columnas.Mostrar(dgvPagos, "Fecha", "Cliente", "Concepto", "MetodoPago=Método", "MontoTotal=Monto", "Usuario=Cobrado por");
            }
            else
            {
                dgvPagos.DataSource = pagoNegocio.ListarPorCliente(cliente.IdCliente);
                tabPagos.Text = "Pagos de " + cliente.Nombre;
                Columnas.Mostrar(dgvPagos, "Fecha", "Concepto", "MetodoPago=Método", "MontoTotal=Monto", "Usuario=Cobrado por");
            }

            if (dgvPagos.Columns.Contains("Fecha"))
            {
                dgvPagos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                dgvPagos.Columns["Concepto"].FillWeight = 160;
                dgvPagos.Columns["MontoTotal"].DefaultCellStyle.Format = "N2";
            }
        }

        private void CargarMorosos()
        {
            dgvMorosos.DataSource = clienteMembresiaNegocio.ListarVencidas();
            Columnas.Mostrar(dgvMorosos, "Cliente", "Cedula=Cédula", "Membresia=Último plan", "FechaFin=Venció el");

            if (dgvMorosos.Columns.Contains("FechaFin"))
            {
                dgvMorosos.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            tabMorosos.Text = "Deben renovar (" + dgvMorosos.Rows.Count + ")";
        }

        private void CargarCreditos()
        {
            dgvCreditos.DataSource = cuentaCobrarNegocio.ListarPendientes();
            Columnas.Mostrar(dgvCreditos, "Cliente", "Cedula=Cédula", "IdVenta=Venta #", "FechaVenta=Fecha", "MontoOriginal=Monto original", "Saldo", "FechaVencimiento=Vence el");

            if (dgvCreditos.Columns.Contains("Saldo"))
            {
                dgvCreditos.Columns["FechaVenta"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvCreditos.Columns["MontoOriginal"].DefaultCellStyle.Format = "N2";
                dgvCreditos.Columns["Saldo"].DefaultCellStyle.Format = "N2";
                dgvCreditos.Columns["FechaVencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            tabCreditos.Text = "Créditos pendientes (" + dgvCreditos.Rows.Count + ")";
        }

        private void dgvMorosos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ClienteMembresia vencida = (ClienteMembresia)dgvMorosos.Rows[e.RowIndex].DataBoundItem;
            Seleccionar(vencida.Cedula);
        }

        private void dgvCreditos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            CuentaCobrar cuenta = (CuentaCobrar)dgvCreditos.Rows[e.RowIndex].DataBoundItem;
            Seleccionar(cuenta.Cedula);
        }

        private void Seleccionar(string cedula)
        {
            Cliente encontrado = clienteNegocio.ObtenerPorCedula(cedula);
            if (encontrado == null) return;

            ClienteSeleccionado = encontrado;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
