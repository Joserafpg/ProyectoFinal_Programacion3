using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VisitaDatos
    {
        // carga la visita del dia al cliente y registra su entrada, todo en una transaccion
        public void RegistrarConEntrada(int idCliente, decimal monto)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string sqlVisita = "insert into visitas (id_cliente, monto) values (@idCliente, @monto)";

                        using (var cmd = new SqlCommand(sqlVisita, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);
                            cmd.Parameters.AddWithValue("@monto", monto);
                            cmd.ExecuteNonQuery();
                        }

                        string sqlAsistencia = "insert into asistencia (id_cliente) values (@idCliente)";

                        using (var cmd = new SqlCommand(sqlAsistencia, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        public List<Visita> ListarPendientes(int idCliente)
        {
            var lista = new List<Visita>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_visita, id_cliente, fecha, monto, estado, id_pago " +
                             "from visitas where id_cliente = @idCliente and estado = 'Pendiente' " +
                             "order by fecha";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Visita
                            {
                                IdVisita = (int)dr["id_visita"],
                                IdCliente = (int)dr["id_cliente"],
                                Fecha = (DateTime)dr["fecha"],
                                Monto = (decimal)dr["monto"],
                                Estado = dr["estado"].ToString(),
                                IdPago = dr["id_pago"] == DBNull.Value ? (int?)null : (int)dr["id_pago"]
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
