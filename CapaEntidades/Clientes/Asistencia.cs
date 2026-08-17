using System;

namespace CapaEntidades
{
    public class Asistencia
    {
        public int IdAsistencia { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
    }
}
