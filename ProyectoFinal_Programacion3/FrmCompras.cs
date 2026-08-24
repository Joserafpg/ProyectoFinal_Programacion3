using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCompras : Form
    {
        CompraNegocio compraNegocio = new CompraNegocio();

        DateTimePicker dtpDesde;
        DateTimePicker dtpHasta;
        ComboBox cboProveedor;
        TextBox txtFactura;

        public FrmCompras()
        {
            InitializeComponent();

            dtpDesde = Filtros.AgregarFecha(panelAcciones, "Desde:", Filtros.InicioDeMes());
            dtpHasta = Filtros.AgregarFecha(panelAcciones, "Hasta:", DateTime.Today);
            cboProveedor = Filtros.AgregarCombo(panelAcciones, "Proveedor:", 220);
            txtFactura = Filtros.AgregarTexto(panelAcciones, "Factura:", 150);

            Load += FrmCompras_Load;
            btnNuevaCompra.Click += btnNuevaCompra_Click;
            dgvCompras.SelectionChanged += dgvCompras_SelectionChanged;
            dgvCompras.DataBindingComplete += dgvCompras_DataBindingComplete;
            dgvDetalle.DataBindingComplete += dgvDetalle_DataBindingComplete;
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            var proveedores = new ProveedorNegocio().Listar();
            proveedores.Insert(0, new Proveedor { IdProveedor = 0, Nombre = "Todos" });
            cboProveedor.DataSource = proveedores;
            cboProveedor.DisplayMember = "Nombre";
            cboProveedor.ValueMember = "IdProveedor";

            CargarCompras();

            dtpDesde.ValueChanged += (s, a) => CargarCompras();
            dtpHasta.ValueChanged += (s, a) => CargarCompras();
            cboProveedor.SelectedIndexChanged += (s, a) => CargarCompras();
            txtFactura.TextChanged += (s, a) => CargarCompras();
        }

        private void CargarCompras()
        {
            int idProveedor = cboProveedor.SelectedValue is int ? (int)cboProveedor.SelectedValue : 0;
            var compras = compraNegocio.Buscar(dtpDesde.Value, dtpHasta.Value, idProveedor, txtFactura.Text);

            dgvCompras.DataSource = compras;
            lblCompras.Text = "Compras registradas · " + compras.Count + " · RD$" + compras.Sum(c => c.Total).ToString("N2");

            if (compras.Count == 0)
            {
                dgvDetalle.DataSource = null;
            }
        }

        private void dgvCompras_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvCompras, "IdCompra=No.", "Fecha", "Proveedor", "NumeroFactura=Factura", "Total", "Usuario=Registrada por");

            if (dgvCompras.Columns.Contains("Fecha"))
            {
                dgvCompras.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                dgvCompras.Columns["Total"].DefaultCellStyle.Format = "N2";
            }
        }

        private void dgvCompras_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCompras.CurrentRow == null) return;

            Compra compra = dgvCompras.CurrentRow.DataBoundItem as Compra;
            if (compra == null) return;

            dgvDetalle.DataSource = compraNegocio.ListarDetalle(compra.IdCompra);
        }

        private void dgvDetalle_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDetalle, "Producto", "Cantidad", "PrecioCompra=Costo", "Subtotal");

            if (dgvDetalle.Columns.Contains("Subtotal"))
            {
                dgvDetalle.Columns["PrecioCompra"].DefaultCellStyle.Format = "N2";
                dgvDetalle.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            }
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            FrmCompra dialogo = new FrmCompra();

            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                CargarCompras();
            }
        }
    }
}
