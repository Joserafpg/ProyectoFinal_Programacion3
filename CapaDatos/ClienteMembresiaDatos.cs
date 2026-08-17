using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClienteMembresiaDatos
    {
        public void Asignar(Pago pago, ClienteMembresia clienteMembresia, string concepto)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int idPago;
                        int idClienteMembresia;

                        string sqlPago = "insert into pagos (id_cliente, id_usuario, metodo_pago, monto_total) " +
                                         "values (@idCliente, @idUsuario, @metodoPago, @montoTotal) " +
                                         "select cast(scope_identity() as int)";

                        using (var cmd = new SqlCommand(sqlPago, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", pago.IdCliente);
                            cmd.Parameters.AddWithValue("@idUsuario", pago.IdUsuario);
                            cmd.Parameters.AddWithValue("@metodoPago", pago.MetodoPago);
                            cmd.Parameters.AddWithValue("@montoTotal", pago.MontoTotal);
                            idPago = (int)cmd.ExecuteScalar();
                        }

                        string sqlMembresia = "insert into cliente_membresia (id_cliente, id_membresia, fecha_inicio, fecha_fin) " +
                                              "values (@idCliente, @idMembresia, @fechaInicio, @fechaFin) " +
                                              "select cast(scope_identity() as int)";

                        using (var cmd = new SqlCommand(sqlMembresia, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", clienteMembresia.IdCliente);
                            cmd.Parameters.AddWithValue("@idMembresia", clienteMembresia.IdMembresia);
                            cmd.Parameters.AddWithValue("@fechaInicio", clienteMembresia.FechaInicio);
                            cmd.Parameters.AddWithValue("@fechaFin", clienteMembresia.FechaFin);
                            idClienteMembresia = (int)cmd.ExecuteScalar();
                        }

                        string sqlDetalle = "insert into pagos_detalle (id_pago, id_cliente_membresia, concepto, monto) " +
                                            "values (@idPago, @idClienteMembresia, @concepto, @monto)";

                        using (var cmd = new SqlCommand(sqlDetalle, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idPago", idPago);
                            cmd.Parameters.AddWithValue("@idClienteMembresia", idClienteMembresia);
                            cmd.Parameters.AddWithValue("@concepto", concepto);
                            cmd.Parameters.AddWithValue("@monto", pago.MontoTotal);
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

        public ClienteMembresia ObtenerActiva(int idCliente)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select top 1 cm.id_cliente_membresia, cm.id_cliente, cm.id_membresia, cm.fecha_inicio, cm.fecha_fin, cm.estado, m.nombre as membresia " +
                             "from cliente_membresia cm " +
                             "inner join membresias m on m.id_membresia = cm.id_membresia " +
                             "where cm.id_cliente = @idCliente and cm.estado = 'Activa' and cm.fecha_fin >= cast(getdate() as date) " +
                             "order by cm.fecha_fin desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return Mapear(dr);
                        }
                    }
                }
            }

            return null;
        }

        public ClienteMembresia ObtenerUltima(int idCliente)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select top 1 cm.id_cliente_membresia, cm.id_cliente, cm.id_membresia, cm.fecha_inicio, cm.fecha_fin, cm.estado, m.nombre as membresia " +
                             "from cliente_membresia cm " +
                             "inner join membresias m on m.id_membresia = cm.id_membresia " +
                             "where cm.id_cliente = @idCliente " +
                             "order by cm.fecha_fin desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return Mapear(dr);
                        }
                    }
                }
            }

            return null;
        }

        public List<ClienteMembresia> ListarVencidas()
        {
            var lista = new List<ClienteMembresia>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select cm.id_cliente_membresia, cm.id_cliente, cm.id_membresia, cm.fecha_inicio, cm.fecha_fin, cm.estado, " +
                             "m.nombre as membresia, c.nombre + ' ' + c.apellido as cliente, c.cedula " +
                             "from cliente_membresia cm " +
                             "inner join membresias m on m.id_membresia = cm.id_membresia " +
                             "inner join clientes c on c.id_cliente = cm.id_cliente " +
                             "where c.estado = 1 " +
                             "and cm.fecha_fin = (select max(cm2.fecha_fin) from cliente_membresia cm2 where cm2.id_cliente = cm.id_cliente) " +
                             "and cm.fecha_fin < cast(getdate() as date) " +
                             "order by cm.fecha_fin";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var vencida = Mapear(dr);
                            vencida.Cliente = dr["cliente"].ToString();
                            vencida.Cedula = dr["cedula"].ToString();
                            lista.Add(vencida);
                        }
                    }
                }
            }

            return lista;
        }

        // ultima membresia de cada cliente que vence entre hoy y los proximos dias indicados
        public List<ClienteMembresia> ListarPorVencer(int dias)
        {
            var lista = new List<ClienteMembresia>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select cm.id_cliente_membresia, cm.id_cliente, cm.id_membresia, cm.fecha_inicio, cm.fecha_fin, cm.estado, " +
                             "m.nombre as membresia, c.nombre + ' ' + c.apellido as cliente, c.cedula " +
                             "from cliente_membresia cm " +
                             "inner join membresias m on m.id_membresia = cm.id_membresia " +
                             "inner join clientes c on c.id_cliente = cm.id_cliente " +
                             "where c.estado = 1 " +
                             "and cm.fecha_fin = (select max(cm2.fecha_fin) from cliente_membresia cm2 where cm2.id_cliente = cm.id_cliente) " +
                             "and cm.fecha_fin between cast(getdate() as date) and dateadd(day, @dias, cast(getdate() as date)) " +
                             "order by cm.fecha_fin";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@dias", dias);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            lista.Add(Mapear(dr));
                    }
                }
            }

            return lista;
        }

        public int ContarActivas()
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select count(*) from clientes c " +
                             "where c.estado = 1 and exists (select 1 from cliente_membresia cm " +
                             "where cm.id_cliente = c.id_cliente and cm.estado = 'Activa' and cm.fecha_fin >= cast(getdate() as date))";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private ClienteMembresia Mapear(SqlDataReader dr)
        {
            return new ClienteMembresia
            {
                IdClienteMembresia = (int)dr["id_cliente_membresia"],
                IdCliente = (int)dr["id_cliente"],
                IdMembresia = (int)dr["id_membresia"],
                FechaInicio = (DateTime)dr["fecha_inicio"],
                FechaFin = (DateTime)dr["fecha_fin"],
                Estado = dr["estado"].ToString(),
                Membresia = dr["membresia"].ToString()
            };
        }
    }
}
