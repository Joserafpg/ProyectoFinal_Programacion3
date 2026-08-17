using System;
using CapaEntidades;
using CapaNegocio;

namespace Pruebas
{
    public class PruebaClientes
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE CLIENTES...");
            var negocio = new ClienteNegocio();

            var error = negocio.Insertar(new Cliente
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Cedula = "402-1234567-1",
                Telefono = "829-555-3030",
                Correo = "juanperez@gmail.com",
                Direccion = "Los Jardines, Santiago",
                FechaNacimiento = new DateTime(2000, 5, 15),
                Sexo = "M"
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Cliente insertado." : "Aviso: " + error));

            var invalido = negocio.Insertar(new Cliente { Nombre = "Pedro", Apellido = "Sin Cedula" });
            Console.WriteLine("[" + DateTime.Now + "] " + (invalido != "" ? "Cliente invalido rechazado: " + invalido : "ERROR: acepto cliente sin cedula!"));

            Console.WriteLine("[" + DateTime.Now + "] Busqueda por 'Juan':");
            foreach (var c in negocio.Listar("Juan"))
            {
                Console.WriteLine("[" + DateTime.Now + "] " + c.IdCliente + " | " + c.NombreCompleto + " | " + c.Cedula + " | " + (c.Estado ? "Activo" : "Inactivo"));
            }

            Console.WriteLine("[" + DateTime.Now + "] Busqueda por cedula '402':");
            foreach (var c in negocio.Listar("402"))
            {
                Console.WriteLine("[" + DateTime.Now + "] " + c.IdCliente + " | " + c.NombreCompleto + " | " + c.Cedula);
            }
        }
    }
}
