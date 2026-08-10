using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            string conexion = ConfigurationManager.ConnectionStrings["GimnasioDB"].ConnectionString;
            return new SqlConnection(conexion);
        }
    }
}
