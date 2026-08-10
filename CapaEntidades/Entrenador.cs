using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Entrenador
    {
        public int IdEntrenador { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Especialidad { get; set; }
        public int IdHorario { get; set; }
        public string Horario { get; set; }
        public bool Estado { get; set; }


        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }
    }
}
