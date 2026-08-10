using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Clase
    {
        public int IdClase { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CupoMaximo { get; set; }
        public bool Estado { get; set; }


        public int IdInstructor { get; set; }
        public string NombreInstructor { get; set; }
    }
}
