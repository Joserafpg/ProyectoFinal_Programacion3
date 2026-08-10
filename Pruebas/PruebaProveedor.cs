using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class PruebaProveedor
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE PROVEEDORES...");
            var negocio = new ProveedorNegocio();

            var error = negocio.Insertar(new Proveedor
            {
                Nombre = "Distribuidora Fitness RD",
                Rnc = "130-12345-6",
                Telefono = "809-555-1234",
                Correo = "ventas@fitnessrd.com",
                Direccion = "Av. Estrella Sadhala, Santiago"
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Proveedor insertado." : "Aviso: " + error));

            foreach (var p in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + p.IdProveedor + " | " + p.Nombre + " | " + p.Rnc + " | " + p.Telefono);
            }
        }
    }
}
