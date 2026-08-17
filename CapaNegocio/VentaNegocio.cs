using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class VentaNegocio
    {
        private VentaDatos datos = new VentaDatos();
        public const int DiasCredito = 30;

        public string Insertar(Venta venta, out int idVenta)
        {
            idVenta = 0;

            if (venta.Detalles == null || venta.Detalles.Count == 0)
                return "Debe agregar al menos un producto a la venta.";

            if (venta.IdUsuario <= 0)
                return "No se pudo identificar el usuario que realiza la venta.";

            if (venta.TipoPago == "Credito" && venta.IdCliente == null)
                return "Para vender a crédito debe seleccionar un cliente.";

            var productos = new ProductoDatos().Listar();

            foreach (var detalle in venta.Detalles)
            {
                if (detalle.Cantidad <= 0)
                    return "La cantidad debe ser mayor que cero.";

                var producto = productos.Find(p => p.IdProducto == detalle.IdProducto);

                if (producto == null)
                    return "Uno de los productos de la venta no existe.";

                if (producto.Stock < detalle.Cantidad)
                    return "Stock insuficiente de " + producto.Nombre + " (disponible: " + producto.Stock + ").";
            }

            try
            {
                idVenta = datos.Insertar(venta, DiasCredito);
                return "";
            }
            catch (Exception ex)
            {
                return "Error al registrar la venta: " + ex.Message;
            }
        }

        public List<Venta> Listar()
        {
            return datos.Listar();
        }

        public List<VentaDetalle> ListarDetalle(int idVenta)
        {
            return datos.ListarDetalle(idVenta);
        }

        public List<Venta> ListarPorCliente(int idCliente)
        {
            return datos.ListarPorCliente(idCliente);
        }

        public decimal ObtenerPorcentajeImpuesto()
        {
            try
            {
                return new ConfiguracionDatos().ObtenerPorcentajeImpuesto();
            }
            catch
            {
                return 0;
            }
        }
    }
}
