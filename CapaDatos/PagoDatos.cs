using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PagoDatos
    {
        public List<Pago> Listar()
        {
            var lista = new List<Pago>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select p.id_pago, p.fecha, p.metodo_pago, d.monto as monto_total, p.estado, " +
                             "d.concepto, c.nombre + ' ' + c.apellido as cliente, u.nombre_completo as usuario " +
                             "from pagos p " +
                             "inner join pagos_detalle d on d.id_pago = p.id_pago " +
                             "inner join clientes c on c.id_cliente = p.id_cliente " +
                             "inner join usuarios u on u.id_usuario = p.id_usuario " +
                             "order by p.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Pago
                            {
                                IdPago = (int)dr["id_pago"],
                                Fecha = (DateTime)dr["fecha"],
                                MetodoPago = dr["metodo_pago"].ToString(),
                                MontoTotal = (decimal)dr["monto_total"],
                                Estado = dr["estado"].ToString(),
                                Concepto = dr["concepto"].ToString(),
                                Cliente = dr["cliente"].ToString(),
                                Usuario = dr["usuario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public List<Pago> ListarPorCliente(int idCliente)
        {
            var lista = new List<Pago>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select p.id_pago, p.fecha, p.metodo_pago, d.monto as monto_total, p.estado, " +
                             "d.concepto, c.nombre + ' ' + c.apellido as cliente, u.nombre_completo as usuario " +
                             "from pagos p " +
                             "inner join pagos_detalle d on d.id_pago = p.id_pago " +
                             "inner join clientes c on c.id_cliente = p.id_cliente " +
                             "inner join usuarios u on u.id_usuario = p.id_usuario " +
                             "where p.id_cliente = @idCliente " +
                             "order by p.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Pago
                            {
                                IdPago = (int)dr["id_pago"],
                                Fecha = (DateTime)dr["fecha"],
                                MetodoPago = dr["metodo_pago"].ToString(),
                                MontoTotal = (decimal)dr["monto_total"],
                                Estado = dr["estado"].ToString(),
                                Concepto = dr["concepto"].ToString(),
                                Cliente = dr["cliente"].ToString(),
                                Usuario = dr["usuario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        // un solo pago que puede incluir membresia, abonos a credito y visita, todo en una transaccion
        public void RegistrarCombinado(Pago pago, List<PagoPendiente> items)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int idPago;

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

                        foreach (var item in items)
                        {
                            object idClienteMembresia = DBNull.Value;

                            if (item.ClienteMembresia != null)
                            {
                                string sqlMembresia = "insert into cliente_membresia (id_cliente, id_membresia, fecha_inicio, fecha_fin) " +
                                                      "values (@idCliente, @idMembresia, @fechaInicio, @fechaFin) " +
                                                      "select cast(scope_identity() as int)";

                                using (var cmd = new SqlCommand(sqlMembresia, conexion, transaccion))
                                {
                                    cmd.Parameters.AddWithValue("@idCliente", item.ClienteMembresia.IdCliente);
                                    cmd.Parameters.AddWithValue("@idMembresia", item.ClienteMembresia.IdMembresia);
                                    cmd.Parameters.AddWithValue("@fechaInicio", item.ClienteMembresia.FechaInicio);
                                    cmd.Parameters.AddWithValue("@fechaFin", item.ClienteMembresia.FechaFin);
                                    idClienteMembresia = (int)cmd.ExecuteScalar();
                                }
                            }

                            string sqlDetalle = "insert into pagos_detalle (id_pago, id_cliente_membresia, concepto, monto) " +
                                                "values (@idPago, @idClienteMembresia, @concepto, @monto)";

                            using (var cmd = new SqlCommand(sqlDetalle, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idPago", idPago);
                                cmd.Parameters.AddWithValue("@idClienteMembresia", idClienteMembresia);
                                cmd.Parameters.AddWithValue("@concepto", item.Concepto);
                                cmd.Parameters.AddWithValue("@monto", item.Monto);
                                cmd.ExecuteNonQuery();
                            }

                            if (item.Cuenta != null)
                            {
                                string sqlAbono = "insert into abonos (id_cuenta, monto, id_usuario) values (@idCuenta, @monto, @idUsuario)";

                                using (var cmd = new SqlCommand(sqlAbono, conexion, transaccion))
                                {
                                    cmd.Parameters.AddWithValue("@idCuenta", item.Cuenta.IdCuenta);
                                    cmd.Parameters.AddWithValue("@monto", item.Monto);
                                    cmd.Parameters.AddWithValue("@idUsuario", pago.IdUsuario);
                                    cmd.ExecuteNonQuery();
                                }

                                string sqlCuenta = "update cuentas_cobrar set saldo = saldo - @monto, " +
                                                   "estado = case when saldo - @monto <= 0 then 'Saldada' else estado end " +
                                                   "where id_cuenta = @idCuenta";

                                using (var cmd = new SqlCommand(sqlCuenta, conexion, transaccion))
                                {
                                    cmd.Parameters.AddWithValue("@monto", item.Monto);
                                    cmd.Parameters.AddWithValue("@idCuenta", item.Cuenta.IdCuenta);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            if (item.Tipo == "Visita")
                            {
                                string sqlAsistencia = "insert into asistencia (id_cliente) values (@idCliente)";

                                using (var cmd = new SqlCommand(sqlAsistencia, conexion, transaccion))
                                {
                                    cmd.Parameters.AddWithValue("@idCliente", pago.IdCliente);
                                    cmd.ExecuteNonQuery();
                                }
                            }
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

        public void RegistrarConDetalle(Pago pago, string concepto)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int idPago;

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

                        string sqlDetalle = "insert into pagos_detalle (id_pago, concepto, monto) " +
                                            "values (@idPago, @concepto, @monto)";

                        using (var cmd = new SqlCommand(sqlDetalle, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idPago", idPago);
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
    }
}
