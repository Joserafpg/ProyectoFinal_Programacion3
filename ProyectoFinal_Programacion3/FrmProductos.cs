using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmProductos : Form
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        ComboBox cboEstado;
        ComboBox cboStock;

        public FrmProductos()
        {
            InitializeComponent();
            cboEstado = Filtros.AgregarEstado(panelBarra);
            cboStock = Filtros.AgregarCombo(panelBarra, "Stock:", 140, "Todos", "Bajo mínimo", "Sin stock");
            cboEstado.SelectedIndexChanged += (s, e) => Cargar();
            cboStock.SelectedIndexChanged += (s, e) => Cargar();
        }

        private void Cargar()
        {
            dgvDatos.DataSource = productoNegocio.Listar(txtBuscar.Text, Filtros.Estado(cboEstado), cboStock.Text);
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Codigo=Código", "Nombre", "NombreCategoria=Categoría", "NombreMarca=Marca", "PrecioCompra=Precio compra", "PrecioVenta=Precio venta", "Stock", "StockMinimo=Stock mínimo", "Estado");
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto dialogo = new FrmProducto();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                Cargar();
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Producto seleccionado = (Producto)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmProducto dialogo = new FrmProducto(seleccionado);
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                Cargar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
