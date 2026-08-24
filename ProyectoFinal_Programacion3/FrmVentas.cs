using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmVentas : Form
    {
        VentaNegocio ventaNegocio = new VentaNegocio();
        int? idCliente = null;

        DateTimePicker dtpDesde;
        DateTimePicker dtpHasta;
        ComboBox cboTipo;
        TextBox txtCliente;

        public FrmVentas()
        {
            InitializeComponent();
            ClientSize = new Size(1100, 640);

            Panel barra = new Panel { Dock = DockStyle.Top, Height = 54 };
            Controls.Add(barra);
            dtpDesde = Filtros.AgregarFecha(barra, "Desde:", Filtros.InicioDeMes());
            dtpHasta = Filtros.AgregarFecha(barra, "Hasta:", DateTime.Today);
            cboTipo = Filtros.AgregarCombo(barra, "Tipo de pago:", 130, "Todos", "Contado", "Crédito");
            txtCliente = Filtros.AgregarTexto(barra, "Cliente:", 220);

            Load += FrmVentas_Load;
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
            dgvVentas.DataBindingComplete += dgvVentas_DataBindingComplete;
            dgvDetalle.DataBindingComplete += dgvDetalle_DataBindingComplete;
        }

        // ventas de un solo cliente (desde su detalle): el filtro de cliente sobra y se abre un año atras
        public FrmVentas(Cliente cliente) : this()
        {
            idCliente = cliente.IdCliente;
            Text = "Compras de " + cliente.NombreCompleto;
            dtpDesde.Value = DateTime.Today.AddYears(-1);
            Filtros.Grupo(txtCliente).Visible = false;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            Cargar();

            dtpDesde.ValueChanged += (s, a) => Cargar();
            dtpHasta.ValueChanged += (s, a) => Cargar();
            cboTipo.SelectedIndexChanged += (s, a) => Cargar();
            txtCliente.TextChanged += (s, a) => Cargar();
        }

        private void Cargar()
        {
            string tipo = cboTipo.SelectedIndex == 1 ? "Contado" : cboTipo.SelectedIndex == 2 ? "Credito" : "";
            var ventas = ventaNegocio.Buscar(dtpDesde.Value, dtpHasta.Value, tipo, txtCliente.Text, idCliente);

            dgvVentas.DataSource = ventas;
            lblVentas.Text = "Ventas · " + ventas.Count + " facturas · RD$" + ventas.Sum(v => v.Total).ToString("N2");

            if (ventas.Count == 0)
            {
                dgvDetalle.DataSource = null;
            }
        }

        private void dgvVentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvVentas, "IdVenta=No.", "Fecha", "Cliente", "Usuario=Vendedor", "TipoPago=Pago", "Total", "Estado");

            if (dgvVentas.Columns.Contains("Fecha"))
            {
                dgvVentas.Columns["IdVenta"].FillWeight = 40;
                dgvVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                dgvVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
            }
        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null) return;

            Venta venta = dgvVentas.CurrentRow.DataBoundItem as Venta;
            if (venta == null) return;

            dgvDetalle.DataSource = ventaNegocio.ListarDetalle(venta.IdVenta);
        }

        private void dgvDetalle_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDetalle, "Producto", "Cantidad", "Precio", "Subtotal");

            if (dgvDetalle.Columns.Contains("Precio"))
            {
                dgvDetalle.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgvDetalle.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            }
        }
    }
}
