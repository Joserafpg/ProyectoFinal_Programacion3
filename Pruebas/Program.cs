using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace Pruebas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestConexion();
            TestLogin();
        }

        public static void TestConexion()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "]" + " " + "INICIANDO PRUEBAS DE CONEXION...");
            using (var conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("[" + DateTime.Now + "]" + " " + "Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
                }
            }
        }

        public static void TestLogin()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "]" + " " + "INICIANDO PRUEBAS DE LOGIN...");
            var negocio = new CapaNegocio.UsuarioNegocio();
            string mensaje;

            Console.WriteLine("[" + DateTime.Now + "]" + " " + "Login con contrasena correcta");
            var usuario = negocio.Login("admin", "Admin123", out mensaje);
            if (usuario != null)
                Console.WriteLine("[" + DateTime.Now + "]" + " " + "Login OK: " + usuario.NombreCompleto + " | Rol: " + usuario.NombreRol + " | Permisos: " + usuario.Permisos.Count);
            else
                Console.WriteLine("[" + DateTime.Now + "]" + " " + "Login fallo: " + mensaje);


            Console.WriteLine("[" + DateTime.Now + "]" + " " + "Login con contrasena incorrecta");
            var malo = negocio.Login("admin", "ClaveMala", out mensaje);
            Console.WriteLine(malo == null ? "[" + DateTime.Now + "]" + " " + "Clave mala rechazada: " + mensaje : "ERROR: dejo entrar con clave mala!");
        }
    }
}
