using System;
using CapaDatos;

namespace Pruebas
{
    public class PruebaConexion
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE CONEXION...");

            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();
                    Console.WriteLine("[" + DateTime.Now + "] Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[" + DateTime.Now + "] Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
