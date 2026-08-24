using CapaEntidades;
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
        public Configuracion Obtener()
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_configuracion, nombre_gimnasio, rnc, telefono, direccion, correo, porcentaje_impuesto, monto_visita, mensaje_recibo " +
                             "from configuracion where id_configuracion = 1";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Configuracion
                            {
                                IdConfiguracion = (int)dr["id_configuracion"],
                                NombreGimnasio = dr["nombre_gimnasio"].ToString(),
                                Rnc = dr["rnc"] == DBNull.Value ? "" : dr["rnc"].ToString(),
                                Telefono = dr["telefono"] == DBNull.Value ? "" : dr["telefono"].ToString(),
                                Direccion = dr["direccion"] == DBNull.Value ? "" : dr["direccion"].ToString(),
                                Correo = dr["correo"] == DBNull.Value ? "" : dr["correo"].ToString(),
                                PorcentajeImpuesto = (decimal)dr["porcentaje_impuesto"],
                                MontoVisita = (decimal)dr["monto_visita"],
                                MensajeRecibo = dr["mensaje_recibo"] == DBNull.Value ? "" : dr["mensaje_recibo"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void Actualizar(Configuracion configuracion)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update configuracion set nombre_gimnasio = @nombre, rnc = @rnc, telefono = @telefono, " +
                             "direccion = @direccion, correo = @correo, porcentaje_impuesto = @impuesto, " +
                             "monto_visita = @montoVisita, mensaje_recibo = @mensaje " +
                             "where id_configuracion = 1";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", configuracion.NombreGimnasio);
                    cmd.Parameters.AddWithValue("@rnc", (object)configuracion.Rnc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@telefono", (object)configuracion.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@direccion", (object)configuracion.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@correo", (object)configuracion.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@impuesto", configuracion.PorcentajeImpuesto);
                    cmd.Parameters.AddWithValue("@montoVisita", configuracion.MontoVisita);
                    cmd.Parameters.AddWithValue("@mensaje", (object)configuracion.MensajeRecibo ?? DBNull.Value);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public decimal ObtenerMontoVisita()
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select monto_visita from configuracion where id_configuracion = 1";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null)
                        throw new InvalidOperationException("No existe la configuración del negocio en la base de datos. Complete la pantalla de Configuración.");

                    return (decimal)resultado;
                }
            }
        }

        public decimal ObtenerPorcentajeImpuesto()
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select porcentaje_impuesto from configuracion where id_configuracion = 1";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null)
                        throw new InvalidOperationException("No existe la configuración del negocio en la base de datos. Complete la pantalla de Configuración.");

                    return (decimal)resultado;
                }
            }
        }
    }
}
