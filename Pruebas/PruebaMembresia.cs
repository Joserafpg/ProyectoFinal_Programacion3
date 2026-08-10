using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class PruebaMembresia
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE MEMBRESIA...");
            var negocio = new MembresiaNegocio();

            var error = negocio.Insertar(new Membresia
            {
                Nombre = "GOLD",
                Descripcion = "Membresia para cools",
                DuracionDias = 30,
                Precio = 99.99m,
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Membresia insertada." : "Aviso: " + error));

            var invalido = negocio.Insertar(new Membresia
            {
                Nombre = "PLATINUM",
                Descripcion = "Membresia de prueba",
                DuracionDias = 0,
                Precio = 99.99m,
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (invalido != "" ? "Membresia invalida rechazada: " + invalido : "ERROR: acepto duracion en cero!"));

            foreach (var h in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + h.IdMembresia + " | " + h.Nombre + " | " + h.Descripcion + " | " + h.DuracionDias + " - " + h.Precio + " - " + h.Estado);
            }
        }
    }
}
