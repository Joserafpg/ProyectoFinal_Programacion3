using System.Collections.Generic;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ProductoNegocio
    {
        private ProductoDatos datos = new ProductoDatos();

        public List<Producto> Listar()
        {
            return datos.Listar();
        }

        public string Insertar(Producto producto)
        {
            string error = Validar(producto);
            if (error != "")
                return error;

            try
            {
                datos.Insertar(producto);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un producto con ese código o código de barras.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Producto producto)
        {
            string error = Validar(producto);
            if (error != "")
                return error;

            try
            {
                datos.Actualizar(producto);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un producto con ese código o código de barras.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idProducto, bool estado)
        {
            try
            {
                datos.CambiarEstado(idProducto, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }

        private string Validar(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Codigo))
                return "El código del producto es obligatorio.";

            if (string.IsNullOrWhiteSpace(producto.Nombre))
                return "El nombre del producto es obligatorio.";

            if (producto.IdCategoria <= 0)
                return "Debe seleccionar una categoría.";

            if (producto.IdMarca <= 0)
                return "Debe seleccionar una marca.";

            if (producto.PrecioCompra < 0 || producto.PrecioVenta < 0)
                return "Los precios no pueden ser negativos.";

            if (producto.PrecioVenta < producto.PrecioCompra)
                return "El precio de venta no puede ser menor que el precio de compra.";

            if (producto.Stock < 0 || producto.StockMinimo < 0)
                return "El stock no puede ser negativo.";

            return "";
        }
    }
}
