using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public List<string> Permisos { get; set; }
    }
}
