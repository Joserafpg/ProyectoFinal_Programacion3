using System;

namespace CapaEntidades
{
    public class ClienteMembresia
    {
        public int IdClienteMembresia { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public string Cedula { get; set; }
        public int IdMembresia { get; set; }
        public string Membresia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
