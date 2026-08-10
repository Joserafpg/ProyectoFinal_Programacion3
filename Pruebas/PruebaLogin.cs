using System;

namespace Pruebas
{
    public class PruebaLogin
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE LOGIN...");
            var negocio = new CapaNegocio.UsuarioNegocio();
            string mensaje;

            Console.WriteLine("[" + DateTime.Now + "] Login con contrasena correcta");
            var usuario = negocio.Login("admin", "Admin123", out mensaje);
            if (usuario != null)
            {
                Console.WriteLine("[" + DateTime.Now + "] Login OK: " + usuario.NombreCompleto + " | Rol: " + usuario.NombreRol + " | Permisos: " + usuario.Permisos.Count);
            }
            else
            {
                Console.WriteLine("[" + DateTime.Now + "] Login fallo: " + mensaje);
            }

            Console.WriteLine("[" + DateTime.Now + "] Login con contrasena incorrecta");
            var malo = negocio.Login("admin", "ClaveMala", out mensaje);
            Console.WriteLine(malo == null ? "[" + DateTime.Now + "] Clave mala rechazada: " + mensaje : "ERROR: dejo entrar con clave mala!");
        }
    }
}
