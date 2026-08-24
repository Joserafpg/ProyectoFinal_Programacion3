using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CompraNegocio
    {
        private CompraDatos datos = new CompraDatos();

        public string Insertar(Compra compra, out int idCompra)
        {
            idCompra = 0;

            if (compra.IdProveedor <= 0)
                return "Debe seleccionar el proveedor.";

            if (compra.IdUsuario <= 0)
                return "No se pudo identificar el usuario que registra la compra.";

            if (compra.Detalles == null || compra.Detalles.Count == 0)
                return "Debe agregar al menos un producto a la compra.";

            foreach (var detalle in compra.Detalles)
            {
                if (detalle.Cantidad <= 0)
                    return "La cantidad de " + detalle.Producto + " debe ser mayor que cero.";

                if (detalle.PrecioCompra < 0)
                    return "El costo de " + detalle.Producto + " no puede ser negativo.";

                detalle.Subtotal = detalle.Cantidad * detalle.PrecioCompra;
            }

            // los totales se calculan aqui, no se confia en lo que mande la pantalla
            compra.Subtotal = compra.Detalles.Sum(d => d.Subtotal);
            compra.Impuesto = 0;
            compra.Total = compra.Subtotal;

            try
            {
                idCompra = datos.Insertar(compra);
                return "";
            }
            catch (Exception ex)
            {
                return "Error al registrar la compra: " + ex.Message;
            }
        }

        public List<Compra> Listar()
        {
            return datos.Listar();
        }

        public List<Compra> Buscar(DateTime desde, DateTime hasta, int idProveedor, string factura)
        {
            if (desde > hasta)
                return new List<Compra>();

            return datos.Buscar(desde, hasta, idProveedor, factura);
        }

        public List<CompraDetalle> ListarDetalle(int idCompra)
        {
            return datos.ListarDetalle(idCompra);
        }
    }
}
