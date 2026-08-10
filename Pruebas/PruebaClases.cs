using System;
using System.Linq;
using CapaEntidades;
using CapaNegocio;

namespace Pruebas
{
    public class PruebaClases
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE CLASES...");
            var negocio = new ClaseNegocio();

            var entrenadores = new EntrenadorNegocio().Listar();
            if (entrenadores.Count == 0)
            {
                Console.WriteLine("[" + DateTime.Now + "] No hay entrenadores registrados, no se puede probar.");
                return;
            }

            // clases no tiene UNIQUE en nombre, se verifica antes para no duplicar en cada corrida
            if (!negocio.Listar().Any(c => c.Nombre == "Spinning"))
            {
                var error = negocio.Insertar(new Clase
                {
                    Nombre = "Spinning",
                    Descripcion = "Cardio en bicicleta",
                    IdEntrenador = entrenadores[0].IdEntrenador,
                    DiaSemana = "Lunes",
                    HoraInicio = new TimeSpan(18, 0, 0),
                    HoraFin = new TimeSpan(19, 0, 0),
                    CupoMaximo = 15
                });
                Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Clase insertada." : "Aviso: " + error));
            }
            else
            {
                Console.WriteLine("[" + DateTime.Now + "] La clase Spinning ya existe, no se inserta de nuevo.");
            }

            var invalida = negocio.Insertar(new Clase
            {
                Nombre = "Yoga",
                IdEntrenador = entrenadores[0].IdEntrenador,
                DiaSemana = "Martes",
                HoraInicio = new TimeSpan(19, 0, 0),
                HoraFin = new TimeSpan(18, 0, 0),
                CupoMaximo = 10
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (invalida != "" ? "Clase invalida rechazada: " + invalida : "ERROR: acepto hora fin menor que inicio!"));

            foreach (var c in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + c.IdClase + " | " + c.Nombre + " | " + c.DiaSemana + " " + c.HoraInicio + "-" + c.HoraFin + " | Cupo: " + c.CupoMaximo + " | " + c.NombreEntrenador);
            }
        }
    }
}
