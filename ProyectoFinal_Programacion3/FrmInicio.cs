using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmInicio : Form
    {
        VentaNegocio ventaNegocio = new VentaNegocio();
        ProductoNegocio productoNegocio = new ProductoNegocio();
        ClienteMembresiaNegocio clienteMembresiaNegocio = new ClienteMembresiaNegocio();

        static readonly int[] OpcionesDiasPorVencer = { 7, 15, 30 };
        static readonly int[] OpcionesDiasAtraso = { 0, 30, 90 };

        ComboBox cboDiasVencer;
        ComboBox cboAtraso;

        public FrmInicio()
        {
            InitializeComponent();

            cboDiasVencer = Filtros.AgregarCombo(panelFiltros, "Próximos:", 110, "7 días", "15 días", "30 días");
            cboAtraso = Filtros.AgregarCombo(panelFiltros, "Vencidas hace:", 160, "Cualquier tiempo", "Más de 30 días", "Más de 90 días");
            cboDiasVencer.SelectedIndexChanged += (s, e) => CargarReporte();
            cboAtraso.SelectedIndexChanged += (s, e) => CargarReporte();

            Load += FrmInicio_Load;
            cboVer.SelectedIndexChanged += cboVer_SelectedIndexChanged;
            dtpDesde.ValueChanged += fechas_ValueChanged;
            dtpHasta.ValueChanged += fechas_ValueChanged;
            dgvDatos.DataBindingComplete += dgvDatos_DataBindingComplete;
            dgvDatos.CellDoubleClick += dgvDatos_CellDoubleClick;

            // click en una tarjeta abre ese reporte
            foreach (Control c in new Control[] { cardVentas, lblCantVentas, lblCardVentas }) c.Click += (s, e) => cboVer.SelectedIndex = 0;
            foreach (Control c in new Control[] { cardStock, lblCantStock, lblCardStock }) c.Click += (s, e) => cboVer.SelectedIndex = 1;
            foreach (Control c in new Control[] { cardMembresias, lblCantMembresias, lblCardMembresias }) c.Click += (s, e) => cboVer.SelectedIndex = 2;
            foreach (Control c in new Control[] { cardMorosos, lblCantMorosos, lblCardMorosos }) c.Click += (s, e) => cboVer.SelectedIndex = 3;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarTarjetas();
            cboVer.SelectedIndex = 0;
        }

        private void CargarTarjetas()
        {
            var ventasHoy = ventaNegocio.ListarPorFecha(DateTime.Today, DateTime.Today);
            lblCantVentas.Text = "RD$" + ventasHoy.Sum(v => v.Total).ToString("N2");
            lblCardVentas.Text = "Ventas de hoy · " + ventasHoy.Count + " facturas";

            lblCantMembresias.Text = clienteMembresiaNegocio.ContarActivas().ToString();

            lblCantMorosos.Text = clienteMembresiaNegocio.ListarVencidas().Count.ToString();
            lblCantStock.Text = productoNegocio.ListarBajoStock().Count.ToString();
        }

        private void cboVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esVentas = cboVer.SelectedIndex == 0;
            lblDesde.Visible = esVentas;
            panelDesde.Visible = esVentas;
            lblHasta.Visible = esVentas;
            panelHasta.Visible = esVentas;
            Filtros.Grupo(cboDiasVencer).Visible = cboVer.SelectedIndex == 2;
            Filtros.Grupo(cboAtraso).Visible = cboVer.SelectedIndex == 3;
            CargarReporte();
        }

        private void fechas_ValueChanged(object sender, EventArgs e)
        {
            if (cboVer.SelectedIndex == 0)
            {
                CargarReporte();
            }
        }

        private void CargarReporte()
        {
            switch (cboVer.SelectedIndex)
            {
                case 0:
                    var ventas = ventaNegocio.ListarPorFecha(dtpDesde.Value, dtpHasta.Value);
                    dgvDatos.DataSource = ventas;
                    lblResumen.Text = ventas.Count + " facturas · Total RD$" + ventas.Sum(v => v.Total).ToString("N2");
                    break;

                case 1:
                    var productos = productoNegocio.ListarBajoStock();
                    dgvDatos.DataSource = productos;
                    lblResumen.Text = productos.Count + " productos en o por debajo del stock mínimo";
                    break;

                case 2:
                    int diasPorVencer = OpcionesDiasPorVencer[cboDiasVencer.SelectedIndex];
                    var porVencer = clienteMembresiaNegocio.ListarPorVencer(diasPorVencer);
                    dgvDatos.DataSource = porVencer;
                    lblResumen.Text = porVencer.Count + " membresías vencen en los próximos " + diasPorVencer + " días";
                    break;

                case 3:
                    int diasAtraso = OpcionesDiasAtraso[cboAtraso.SelectedIndex];
                    var vencidas = clienteMembresiaNegocio.ListarVencidas()
                        .Where(v => (DateTime.Today - v.FechaFin).Days >= diasAtraso).ToList();
                    dgvDatos.DataSource = vencidas;
                    lblResumen.Text = vencidas.Count + " clientes con la membresía vencida" + (diasAtraso > 0 ? " hace más de " + diasAtraso + " días" : "");
                    break;
            }
        }

        // las columnas se configuran aqui porque es cuando el grid ya las genero
        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            switch (cboVer.SelectedIndex)
            {
                case 0:
                    Columnas.Mostrar(dgvDatos, "IdVenta=Factura #", "Fecha", "Cliente", "TipoPago=Tipo de pago", "Subtotal", "Impuesto=ITBIS", "Total", "Usuario=Vendedor");
                    dgvDatos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                    dgvDatos.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
                    dgvDatos.Columns["Impuesto"].DefaultCellStyle.Format = "N2";
                    dgvDatos.Columns["Total"].DefaultCellStyle.Format = "N2";
                    break;

                case 1:
                    Columnas.Mostrar(dgvDatos, "Codigo=Código", "Nombre", "NombreCategoria=Categoría", "NombreMarca=Marca", "Stock", "StockMinimo=Stock mínimo", "PrecioVenta=Precio venta");
                    dgvDatos.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
                    break;

                case 2:
                    Columnas.Mostrar(dgvDatos, "Cliente", "Cedula=Cédula", "Membresia=Plan", "FechaInicio=Inició el", "FechaFin=Vence el");
                    dgvDatos.Columns["FechaInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvDatos.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    break;

                case 3:
                    Columnas.Mostrar(dgvDatos, "Cliente", "Cedula=Cédula", "Membresia=Último plan", "FechaFin=Venció el");
                    dgvDatos.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    break;
            }

            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        // doble click en una venta abre su detalle
        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || cboVer.SelectedIndex != 0) return;

            Venta venta = (Venta)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            new FrmDetalleVenta(venta).ShowDialog(this);
        }
    }
}
