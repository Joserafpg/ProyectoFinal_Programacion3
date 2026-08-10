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
        }

        public static void TestConexion()
        {
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
    }
}
