using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmProducto : Form
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        Producto productoEditar = null;
        byte[] imagen = null;

        public FrmProducto()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            txtCodigoBarras.KeyPress += Validaciones.SoloNumeros;
            txtPrecioCompra.KeyPress += Validaciones.SoloDecimales;
            txtPrecioVenta.KeyPress += Validaciones.SoloDecimales;
            txtStock.KeyPress += Validaciones.SoloNumeros;
            txtStockMinimo.KeyPress += Validaciones.SoloNumeros;

            cboCategoria.DataSource = new CategoriaNegocio().Listar();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "IdCategoria";

            cboMarca.DataSource = new MarcaNegocio().Listar();
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "IdMarca";

            btnDesactivar.Visible = false;
        }

        public FrmProducto(Producto producto) : this()
        {
            productoEditar = producto;

            Text = "Editar Producto";
            btnGuardar.Text = "Actualizar";

            // el stock solo se mueve con ventas y compras; editarlo aqui pisaria esos movimientos
            txtStock.Enabled = false;

            txtCodigo.Text = producto.Codigo;
            txtCodigoBarras.Text = producto.CodigoBarras;
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            cboCategoria.SelectedValue = producto.IdCategoria;
            cboMarca.SelectedValue = producto.IdMarca;
            txtPrecioCompra.Text = producto.PrecioCompra.ToString();
            txtPrecioVenta.Text = producto.PrecioVenta.ToString();
            txtStock.Text = producto.Stock.ToString();
            txtStockMinimo.Text = producto.StockMinimo.ToString();

            if (producto.Imagen != null)
            {
                imagen = producto.Imagen;
                picImagen.Image = Image.FromStream(new MemoryStream(imagen));
            }

            EstadoToggle.Reemplazar(btnDesactivar, producto.Estado, "este producto", estado => productoNegocio.CambiarEstado(producto.IdProducto, estado));
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Imagenes|*.jpg;*.jpeg;*.png";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                imagen = File.ReadAllBytes(buscador.FileName);
                picImagen.Image = Image.FromStream(new MemoryStream(imagen));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMarca.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una marca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra))
            {
                MessageBox.Show("El precio de compra debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta))
            {
                MessageBox.Show("El precio de venta debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStockMinimo.Text, out int stockMinimo))
            {
                MessageBox.Show("El stock mínimo debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje;

            if (productoEditar == null)
            {
                Producto producto = new Producto();
                producto.Codigo = txtCodigo.Text;
                producto.CodigoBarras = txtCodigoBarras.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.IdCategoria = (int)cboCategoria.SelectedValue;
                producto.IdMarca = (int)cboMarca.SelectedValue;
                producto.PrecioCompra = precioCompra;
                producto.PrecioVenta = precioVenta;
                producto.Stock = stock;
                producto.StockMinimo = stockMinimo;
                producto.Imagen = imagen;
                producto.Estado = true;

                mensaje = productoNegocio.Insertar(producto);
            }
            else
            {
                productoEditar.Codigo = txtCodigo.Text;
                productoEditar.CodigoBarras = txtCodigoBarras.Text;
                productoEditar.Nombre = txtNombre.Text;
                productoEditar.Descripcion = txtDescripcion.Text;
                productoEditar.IdCategoria = (int)cboCategoria.SelectedValue;
                productoEditar.IdMarca = (int)cboMarca.SelectedValue;
                productoEditar.PrecioCompra = precioCompra;
                productoEditar.PrecioVenta = precioVenta;
                productoEditar.StockMinimo = stockMinimo;
                productoEditar.Imagen = imagen;

                mensaje = productoNegocio.Actualizar(productoEditar);
            }

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Operacion realizada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de desactivar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = productoNegocio.CambiarEstado(productoEditar.IdProducto, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Producto desactivado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
