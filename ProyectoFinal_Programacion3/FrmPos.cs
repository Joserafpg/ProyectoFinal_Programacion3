using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmPos : Form
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        VentaNegocio ventaNegocio = new VentaNegocio();
        List<Producto> productos = new List<Producto>();
        List<VentaDetalle> carrito = new List<VentaDetalle>();
        decimal porcentajeImpuesto = 0;

        public FrmPos()
        {
            InitializeComponent();
            Load += FrmPos_Load;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            btnQuitar.Click += btnQuitar_Click;
            btnCobrar.Click += btnCobrar_Click;
        }

        private void FrmPos_Load(object sender, EventArgs e)
        {
            porcentajeImpuesto = ventaNegocio.ObtenerPorcentajeImpuesto();

            var clientes = new ClienteNegocio().Listar();
            clientes.Insert(0, new Cliente { IdCliente = 0, Nombre = "Consumidor", Apellido = "final" });
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "IdCliente";

            cboTipoPago.SelectedIndex = 0;

            CargarProductos();
            RefrescarCarrito();
        }

        private void CargarProductos()
        {
            productos = productoNegocio.Listar().Where(p => p.Estado).ToList();
            MostrarProductos(productos);
        }

        private void MostrarProductos(List<Producto> lista)
        {
            dgvProductos.DataSource = null;
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

            var linea = carrito.Find(c => c.IdProducto == producto.IdProducto);
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
            }

            RefrescarCarrito();
        }

        private void RefrescarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;

            string[] visibles = { "Producto", "Cantidad", "Precio", "Subtotal" };
            foreach (DataGridViewColumn columna in dgvCarrito.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            dgvCarrito.ClearSelection();

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
            RefrescarCarrito();
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
            venta.IdCliente = (int)cboCliente.SelectedValue == 0 ? (int?)null : (int)cboCliente.SelectedValue;
            venta.IdUsuario = Sesion.UsuarioActual.IdUsuario;
            venta.TipoPago = cboTipoPago.Text;
            venta.Subtotal = subtotal;
            venta.Descuento = 0;
            venta.Impuesto = impuesto;
            venta.Total = subtotal + impuesto;
            venta.Detalles = carrito;

            string mensaje = ventaNegocio.Insertar(venta, out int idVenta);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Venta #" + idVenta + " registrada. Total: RD$" + venta.Total.ToString("N2"), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carrito = new List<VentaDetalle>();
                txtBuscar.Clear();
                RefrescarCarrito();
                CargarProductos();
            }
        }
    }
}
