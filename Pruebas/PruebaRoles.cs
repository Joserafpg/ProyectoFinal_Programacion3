using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class PruebaRoles
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE ROLES...");
            var negocio = new RolNegocio();

            var error = negocio.Insertar(new Rol { Nombre = "Supervisor", Descripcion = "Consulta reportes y cuadre de caja" });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Rol insertado." : "Aviso: " + error));

            foreach (var r in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + r.IdRol + " | " + r.Nombre + " | " + (r.Estado ? "Activo" : "Inactivo"));
            }
        }
    }
}
