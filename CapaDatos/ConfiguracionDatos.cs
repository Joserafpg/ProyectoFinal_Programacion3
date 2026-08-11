using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConfiguracionDatos
    {
        public decimal ObtenerPorcentajeImpuesto()
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select porcentaje_impuesto from configuracion where id_configuracion = 1";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();
                    object resultado = cmd.ExecuteScalar();
                    return resultado == null ? 0 : (decimal)resultado;
                }
            }
        }
    }
}
