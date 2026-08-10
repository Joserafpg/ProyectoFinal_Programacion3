using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Membresia
    {
        public int idMembresia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int DuracionDias { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
