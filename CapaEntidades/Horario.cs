using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Horario
    {
        public int IdHorario { get; set; }
        public string Nombre { get; set; }
        public string Dias { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFin { get; set; }
        public bool Estado { get; set; }
    }
}
