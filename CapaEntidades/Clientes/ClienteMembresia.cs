using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ClienteMembresia
    {
        public int IdClienteMembresia { get; set; }
        public int IdCliente { get; set; }
        public int IdMembresia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }

        public string Membresia { get; set; }
        public string Cliente { get; set; }
        public string Cedula { get; set; }
    }
}
