using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmHistorialPagos : Form
    {
        PagoNegocio pagoNegocio = new PagoNegocio();

        Cliente cliente = null;

        DateTimePicker dtpDesde;
        DateTimePicker dtpHasta;
        ComboBox cboMetodo;
        TextBox txtCliente;

        public FrmHistorialPagos()
        {
            InitializeComponent();

            Panel barra = new Panel { Dock = DockStyle.Top, Height = 54 };
            Controls.Add(barra);
            dtpDesde = Filtros.AgregarFecha(barra, "Desde:", Filtros.InicioDeMes());
            dtpHasta = Filtros.AgregarFecha(barra, "Hasta:", DateTime.Today);
            cboMetodo = Filtros.AgregarCombo(barra, "Método:", 140, "Todos", "Efectivo", "Tarjeta", "Transferencia");
            txtCliente = Filtros.AgregarTexto(barra, "Cliente:", 220);

            Load += FrmHistorialPagos_Load;
            dgvPagos.CellDoubleClick += dgvPagos_CellDoubleClick;
            dgvPagos.DataBindingComplete += dgvPagos_DataBindingComplete;
        }

        // con cliente muestra solo sus pagos (un año atras); sin cliente, todos los del gimnasio
        public FrmHistorialPagos(Cliente clienteActual) : this()
        {
            cliente = clienteActual;

            if (cliente != null)
            {
                Text = "Historial de pagos de " + cliente.NombreCompleto;
                dtpDesde.Value = DateTime.Today.AddYears(-1);
                Filtros.Grupo(txtCliente).Visible = false;
            }
        }

        private void FrmHistorialPagos_Load(object sender, EventArgs e)
        {
            Cargar();

            dtpDesde.ValueChanged += (s, a) => Cargar();
            dtpHasta.ValueChanged += (s, a) => Cargar();
            cboMetodo.SelectedIndexChanged += (s, a) => Cargar();
            txtCliente.TextChanged += (s, a) => Cargar();
        }

        private void Cargar()
        {
            string metodo = cboMetodo.SelectedIndex == 0 ? "" : cboMetodo.Text;
            var pagos = pagoNegocio.Buscar(dtpDesde.Value, dtpHasta.Value, metodo, txtCliente.Text, cliente == null ? (int?)null : cliente.IdCliente);

            dgvPagos.DataSource = pagos;

            lblInfo.Text = pagos.Count == 0
                ? "No hay pagos en ese período."
                : pagos.Count + " pago(s) · RD$" + pagos.Sum(p => p.MontoTotal).ToString("N2") + "   ·   Doble click sobre un pago para ver qué se cobró esa vez";
        }

        private void dgvPagos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (cliente == null)
                Columnas.Mostrar(dgvPagos, "IdPago=No.", "Fecha", "Cliente", "Concepto", "MetodoPago=Método", "MontoTotal=Total", "Usuario=Cobrado por");
            else
                Columnas.Mostrar(dgvPagos, "IdPago=No.", "Fecha", "Concepto", "MetodoPago=Método", "MontoTotal=Total", "Usuario=Cobrado por");

            if (dgvPagos.Columns.Contains("Fecha"))
            {
                dgvPagos.Columns["IdPago"].FillWeight = 40;
                dgvPagos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                dgvPagos.Columns["Concepto"].FillWeight = 200;
                dgvPagos.Columns["MontoTotal"].DefaultCellStyle.Format = "N2";
            }

            dgvPagos.ClearSelection();
            dgvPagos.CurrentCell = null;
        }

        // doble click en un pago abre lo que se cobro esa vez
        private void dgvPagos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Pago pago = (Pago)dgvPagos.Rows[e.RowIndex].DataBoundItem;
            new FrmDetallePago(pago).ShowDialog(this);
        }
    }
}
