using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmPos : Form
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        VentaNegocio ventaNegocio = new VentaNegocio();
        List<Producto> productos = new List<Producto>();
        BindingList<VentaDetalle> carrito = new BindingList<VentaDetalle>();
        Cliente clienteSeleccionado = null;
        decimal porcentajeImpuesto = 0;

        public FrmPos()
        {
            InitializeComponent();
            Load += FrmPos_Load;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            dgvCarrito.CellEndEdit += dgvCarrito_CellEndEdit;
            dgvCarrito.DataError += dgvCarrito_DataError;
            btnQuitar.Click += btnQuitar_Click;
            btnCobrar.Click += btnCobrar_Click;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            btnVerVentas.Click += btnVerVentas_Click;
        }

        private void FrmPos_Load(object sender, EventArgs e)
        {
            porcentajeImpuesto = ventaNegocio.ObtenerPorcentajeImpuesto();

            cboTipoPago.SelectedIndex = 0;

            dgvCarrito.DataSource = carrito;
            ConfigurarColumnasCarrito();

            CargarProductos();
            CalcularTotales();
        }

        private void ConfigurarColumnasCarrito()
        {
            string[] visibles = { "Producto", "Cantidad", "Precio", "Subtotal" };

            dgvCarrito.ReadOnly = false;

            foreach (DataGridViewColumn columna in dgvCarrito.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
                columna.ReadOnly = columna.Name != "Cantidad";
            }
        }

        private void CargarProductos()
        {
            productos = productoNegocio.Listar().Where(p => p.Estado).ToList();
            MostrarProductos(productos);
        }

        private void MostrarProductos(List<Producto> lista)
        {
            dgvProductos.DataSource = lista;

            string[] visibles = { "Codigo", "Nombre", "PrecioVenta", "Stock" };
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvProductos.Columns.Contains("PrecioVenta"))
            {
                dgvProductos.Columns["PrecioVenta"].HeaderText = "Precio";
            }

            dgvProductos.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.ToLower();
            var filtrados = productos.Where(p => p.Nombre.ToLower().Contains(texto)
                || (p.Codigo != null && p.Codigo.ToLower().Contains(texto))).ToList();
            MostrarProductos(filtrados);
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Producto producto = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

            var linea = carrito.FirstOrDefault(c => c.IdProducto == producto.IdProducto);
            int cantidadActual = linea == null ? 0 : linea.Cantidad;

            if (cantidadActual + 1 > producto.Stock)
            {
                MessageBox.Show("No hay más stock disponible de " + producto.Nombre + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (linea == null)
            {
                carrito.Add(new VentaDetalle
                {
                    IdProducto = producto.IdProducto,
                    Producto = producto.Nombre,
                    Cantidad = 1,
                    Precio = producto.PrecioVenta,
                    Subtotal = producto.PrecioVenta
                });
            }
            else
            {
                linea.Cantidad++;
                linea.Subtotal = linea.Cantidad * linea.Precio;
                dgvCarrito.Refresh();
            }

            CalcularTotales();
        }

        private void dgvCarrito_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCarrito.Columns[e.ColumnIndex].Name != "Cantidad") return;

            VentaDetalle linea = carrito[e.RowIndex];
            var producto = productos.Find(p => p.IdProducto == linea.IdProducto);

            if (linea.Cantidad <= 0)
            {
                linea.Cantidad = 1;
            }

            if (producto != null && linea.Cantidad > producto.Stock)
            {
                MessageBox.Show("Solo hay " + producto.Stock + " disponibles de " + producto.Nombre + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                linea.Cantidad = producto.Stock;
            }

            linea.Subtotal = linea.Cantidad * linea.Precio;
            dgvCarrito.Refresh();
            CalcularTotales();
        }

        private void dgvCarrito_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("La cantidad debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CalcularTotales()
        {
            decimal subtotal = carrito.Sum(c => c.Subtotal);
            decimal impuesto = Math.Round(subtotal * porcentajeImpuesto / 100, 2);
            decimal total = subtotal + impuesto;

            lblSubtotal.Text = "Subtotal: RD$" + subtotal.ToString("N2");
            lblImpuesto.Text = "ITBIS (" + porcentajeImpuesto.ToString("0.##") + "%): RD$" + impuesto.ToString("N2");
            lblTotal.Text = "Total: RD$" + total.ToString("N2");
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null) return;

            VentaDetalle linea = (VentaDetalle)dgvCarrito.CurrentRow.DataBoundItem;
            carrito.Remove(linea);
            CalcularTotales();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("Debe iniciar sesión para registrar ventas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = carrito.Sum(c => c.Subtotal);
            decimal impuesto = Math.Round(subtotal * porcentajeImpuesto / 100, 2);

            Venta venta = new Venta();
            venta.IdCliente = clienteSeleccionado == null ? (int?)null : clienteSeleccionado.IdCliente;
            venta.IdUsuario = Sesion.UsuarioActual.IdUsuario;
            venta.TipoPago = cboTipoPago.Text;
            venta.Subtotal = subtotal;
            venta.Descuento = 0;
            venta.Impuesto = impuesto;
            venta.Total = subtotal + impuesto;
            venta.Detalles = carrito.ToList();

            string mensaje = ventaNegocio.Insertar(venta, out int idVenta);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string aviso = "Venta #" + idVenta + " registrada. Total: RD$" + venta.Total.ToString("N2");

                if (venta.TipoPago == "Credito")
                {
                    aviso += "\n\nQueda a crédito a nombre de " + clienteSeleccionado.NombreCompleto + ". Vence el " + DateTime.Today.AddDays(VentaNegocio.DiasCredito).ToString("dd/MM/yyyy") + ".";
                }

                MessageBox.Show(aviso, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carrito.Clear();
                txtBuscar.Clear();
                clienteSeleccionado = null;
                txtCliente.Text = "Consumidor final";
                CalcularTotales();
                CargarProductos();
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente dialogo = new FrmBuscarCliente();

            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                clienteSeleccionado = dialogo.ClienteSeleccionado;
                txtCliente.Text = clienteSeleccionado == null ? "Consumidor final" : clienteSeleccionado.NombreCompleto;
            }
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            new FrmVentas().ShowDialog(this);
        }

        // doble click sobre una linea del carrito la quita, con confirmacion
        private void dgvCarrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            VentaDetalle detalle = (VentaDetalle)dgvCarrito.Rows[e.RowIndex].DataBoundItem;

            if (MessageBox.Show("¿Desea quitar " + detalle.Producto + " del carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                carrito.Remove(detalle);
                CalcularTotales();
            }
        }
    }
}
