using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCompra : Form
    {
        CompraNegocio compraNegocio = new CompraNegocio();
        List<Producto> productos = new List<Producto>();
        BindingList<CompraDetalle> carrito = new BindingList<CompraDetalle>();

        public FrmCompra()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            Load += FrmCompra_Load;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            dgvCarrito.CellEndEdit += dgvCarrito_CellEndEdit;
            dgvCarrito.CellDoubleClick += dgvCarrito_CellDoubleClick;
            dgvCarrito.DataError += dgvCarrito_DataError;
            btnGuardar.Click += btnGuardar_Click;
            btnCerrar.Click += btnCerrar_Click;
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            cboProveedor.DataSource = new ProveedorNegocio().Listar().Where(p => p.Estado).ToList();
            cboProveedor.DisplayMember = "Nombre";
            cboProveedor.ValueMember = "IdProveedor";

            dgvCarrito.DataSource = carrito;
            ConfigurarColumnasCarrito();

            productos = new ProductoNegocio().Listar().Where(p => p.Estado).ToList();
            MostrarProductos(productos);
            ActualizarTotal();
        }

        private void ConfigurarColumnasCarrito()
        {
            string[] visibles = { "Producto", "Cantidad", "PrecioCompra", "Subtotal" };

            dgvCarrito.ReadOnly = false;

            foreach (DataGridViewColumn columna in dgvCarrito.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
                columna.ReadOnly = columna.Name != "Cantidad" && columna.Name != "PrecioCompra";
            }

            if (dgvCarrito.Columns.Contains("PrecioCompra"))
            {
                dgvCarrito.Columns["PrecioCompra"].HeaderText = "Costo";
                dgvCarrito.Columns["PrecioCompra"].DefaultCellStyle.Format = "N2";
                dgvCarrito.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            }
        }

        private void MostrarProductos(List<Producto> lista)
        {
            dgvProductos.DataSource = lista;

            string[] visibles = { "Codigo", "Nombre", "Stock", "PrecioCompra" };
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvProductos.Columns.Contains("PrecioCompra"))
            {
                dgvProductos.Columns["Codigo"].HeaderText = "Código";
                dgvProductos.Columns["PrecioCompra"].HeaderText = "Último costo";
                dgvProductos.Columns["PrecioCompra"].DefaultCellStyle.Format = "N2";
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

            if (linea == null)
            {
                carrito.Add(new CompraDetalle
                {
                    IdProducto = producto.IdProducto,
                    Producto = producto.Nombre,
                    Cantidad = 1,
                    PrecioCompra = producto.PrecioCompra,
                    Subtotal = producto.PrecioCompra
                });
            }
            else
            {
                linea.Cantidad++;
                linea.Subtotal = linea.Cantidad * linea.PrecioCompra;
                dgvCarrito.Refresh();
            }

            ActualizarTotal();
        }

        private void dgvCarrito_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CompraDetalle linea = carrito[e.RowIndex];

            if (linea.Cantidad <= 0)
            {
                linea.Cantidad = 1;
            }

            if (linea.PrecioCompra < 0)
            {
                linea.PrecioCompra = 0;
            }

            linea.Subtotal = linea.Cantidad * linea.PrecioCompra;
            dgvCarrito.Refresh();
            ActualizarTotal();
        }

        private void dgvCarrito_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("El valor debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // doble click sobre una linea del carrito la quita, con confirmacion
        private void dgvCarrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            CompraDetalle detalle = (CompraDetalle)dgvCarrito.Rows[e.RowIndex].DataBoundItem;

            if (MessageBox.Show("¿Desea quitar " + detalle.Producto + " de la compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                carrito.Remove(detalle);
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            decimal total = carrito.Sum(c => c.Subtotal);
            lblTotal.Text = "Total: RD$" + total.ToString("N2");
            btnGuardar.Text = carrito.Count > 0 ? "Registrar compra RD$" + total.ToString("N2") : "Registrar compra";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("Debe iniciar sesión para registrar compras.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboProveedor.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Compra compra = new Compra();
            compra.IdProveedor = (int)cboProveedor.SelectedValue;
            compra.IdUsuario = Sesion.UsuarioActual.IdUsuario;
            compra.NumeroFactura = txtFactura.Text;
            compra.Detalles = carrito.ToList();

            string mensaje = compraNegocio.Insertar(compra, out int idCompra);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Compra #" + idCompra + " registrada. El stock de los productos fue actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
