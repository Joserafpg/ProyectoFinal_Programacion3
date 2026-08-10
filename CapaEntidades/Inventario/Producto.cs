using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public byte[] Imagen { get; set; }
        public bool Estado { get; set; }


        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
    }
}
