using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class PruebaHorarios
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE HORARIOS...");
            var negocio = new HorarioNegocio();

            var error = negocio.Insertar(new Horario
            {
                Nombre = "Matutino",
                Dias = "Lunes a Viernes",
                HoraInicio = new TimeSpan(6, 0, 0),
                HoraFin = new TimeSpan(14, 0, 0)
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Horario insertado." : "Aviso: " + error));

            var invalido = negocio.Insertar(new Horario
            {
                Nombre = "Malo",
                Dias = "Lunes",
                HoraInicio = new TimeSpan(14, 0, 0),
                HoraFin = new TimeSpan(6, 0, 0)
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (invalido != "" ? "Horario invalido rechazado: " + invalido : "ERROR: acepto hora fin menor que inicio!"));

            foreach (var h in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + h.IdHorario + " | " + h.Nombre + " | " + h.Dias + " | " + h.HoraInicio + " - " + h.HoraFin);
            }
        }
    }
}
