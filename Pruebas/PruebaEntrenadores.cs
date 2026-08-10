using System;
using CapaEntidades;
using CapaNegocio;

namespace Pruebas
{
    public class PruebaEntrenadores
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE ENTRENADORES...");
            var negocio = new EntrenadorNegocio();

            var horarios = new HorarioNegocio().Listar();
            if (horarios.Count == 0)
            {
                Console.WriteLine("[" + DateTime.Now + "] No hay horarios registrados, no se puede probar.");
                return;
            }

            var error = negocio.Insertar(new Entrenador
            {
                Nombre = "Carlos",
                Apellido = "Peña",
                Cedula = "001-1234567-8",
                Telefono = "809-555-2020",
                Especialidad = "Pesas",
                IdHorario = horarios[0].IdHorario
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Entrenador insertado." : "Aviso: " + error));

            var invalido = negocio.Insertar(new Entrenador { Nombre = "Sin", Apellido = "Horario", Cedula = "999-9999999-9", IdHorario = 0 });
            Console.WriteLine("[" + DateTime.Now + "] " + (invalido != "" ? "Entrenador invalido rechazado: " + invalido : "ERROR: acepto entrenador sin horario!"));

            foreach (var e in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + e.IdEntrenador + " | " + e.NombreCompleto + " | " + e.Especialidad + " | Horario: " + e.Horario);
            }
        }
    }
}
