using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmVentas : Form
    {
        VentaNegocio ventaNegocio = new VentaNegocio();

        public FrmVentas()
        {
            InitializeComponent();
            Load += FrmVentas_Load;
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = ventaNegocio.Listar();

            string[] visibles = { "IdVenta", "Fecha", "Cliente", "Usuario", "TipoPago", "Total", "Estado" };
            foreach (DataGridViewColumn columna in dgvVentas.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvVentas.Columns.Contains("IdVenta"))
            {
                dgvVentas.Columns["IdVenta"].HeaderText = "No.";
            }

            if (dgvVentas.Columns.Contains("TipoPago"))
            {
                dgvVentas.Columns["TipoPago"].HeaderText = "Pago";
            }
        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null) return;

            Venta venta = dgvVentas.CurrentRow.DataBoundItem as Venta;
            if (venta == null) return;

            dgvDetalle.DataSource = ventaNegocio.ListarDetalle(venta.IdVenta);

            string[] visibles = { "Producto", "Cantidad", "Precio", "Subtotal" };
            foreach (DataGridViewColumn columna in dgvDetalle.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }
        }
    }
}
