using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmDetalleVenta : Form
    {
        Venta venta;

        public FrmDetalleVenta()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            Load += FrmDetalleVenta_Load;
            btnImprimir.Click += btnImprimir_Click;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (venta == null) return;

            new FrmFactura(venta).ShowDialog(this);
        }

        public FrmDetalleVenta(Venta ventaSeleccionada) : this()
        {
            venta = ventaSeleccionada;
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            if (venta == null) return;

            lblResumen.Text = "Venta #" + venta.IdVenta + " · " + venta.Fecha.ToString("dd/MM/yyyy hh:mm tt")
                + " · " + venta.TipoPago + " · Total: RD$" + venta.Total.ToString("N2");

            dgvDetalleVenta.DataSource = new VentaNegocio().ListarDetalle(venta.IdVenta);

            string[] visibles = { "Producto", "Cantidad", "Precio", "Subtotal" };
            foreach (DataGridViewColumn columna in dgvDetalleVenta.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvDetalleVenta.Columns.Contains("Precio"))
            {
                dgvDetalleVenta.Columns["Precio"].DefaultCellStyle.Format = "N2";
            }

            if (dgvDetalleVenta.Columns.Contains("Subtotal"))
            {
                dgvDetalleVenta.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            }

            dgvDetalleVenta.ClearSelection();
        }
    }
}
