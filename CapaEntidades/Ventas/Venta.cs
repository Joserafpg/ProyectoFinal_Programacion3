using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public string TipoPago { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

        public string Cliente { get; set; }
        public string Usuario { get; set; }
        public List<VentaDetalle> Detalles { get; set; }
    }
}
