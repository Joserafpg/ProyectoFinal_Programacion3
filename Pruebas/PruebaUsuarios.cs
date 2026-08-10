using System;
using CapaEntidades;
using CapaNegocio;

namespace Pruebas
{
    public class PruebaUsuarios
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE USUARIOS...");
            var negocio = new UsuarioNegocio();

            var error = negocio.Insertar(new Usuario
            {
                NombreUsuario = "cajero1",
                NombreCompleto = "Maria Rodriguez",
                Correo = "maria@gimnasio.com",
                IdRol = 2
            }, "Cajero123");
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Usuario insertado." : "Aviso: " + error));

            var claveCorta = negocio.Insertar(new Usuario
            {
                NombreUsuario = "temporal",
                NombreCompleto = "Usuario Temporal",
                IdRol = 2
            }, "123");
            Console.WriteLine("[" + DateTime.Now + "] " + (claveCorta != "" ? "Clave corta rechazada: " + claveCorta : "ERROR: acepto clave de 3 caracteres!"));

            string mensaje;
            var login = negocio.Login("cajero1", "Cajero123", out mensaje);
            if (login != null)
                Console.WriteLine("[" + DateTime.Now + "] Login del nuevo usuario OK: " + login.NombreCompleto + " | Rol: " + login.NombreRol + " | Permisos: " + login.Permisos.Count);
            else
                Console.WriteLine("[" + DateTime.Now + "] ERROR: el nuevo usuario no pudo entrar: " + mensaje);

            foreach (var u in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + u.IdUsuario + " | " + u.NombreUsuario + " | " + u.NombreCompleto + " | " + u.NombreRol + " | " + (u.Estado ? "Activo" : "Inactivo"));
            }
        }
    }
}
