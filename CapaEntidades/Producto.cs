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
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public int CantidadMinima { get; set; }
        public byte[] Foto { get; set; }
        public bool Estado { get; set; }


        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
    }
}
