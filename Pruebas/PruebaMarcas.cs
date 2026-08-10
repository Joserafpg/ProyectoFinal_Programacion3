using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class PruebaMarcas
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE MARCAS...");
            var negocio = new MarcaNegocio();

            var error = negocio.Insertar(new Marca { Nombre = "GymTech" });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Marca insertada." : "Aviso: " + error));

            foreach (var m in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + m.IdMarca + " | " + m.Nombre + " | " + (m.Estado ? "Activa" : "Inactiva"));
            }
        }
    }
}