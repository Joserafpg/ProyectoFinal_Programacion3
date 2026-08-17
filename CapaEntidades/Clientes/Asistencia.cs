using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Asistencia
    {
        public int IdAsistencia { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }

        public string Cliente { get; set; }
    }
}
