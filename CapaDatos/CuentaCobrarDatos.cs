using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CuentaCobrarDatos
    {
        public List<CuentaCobrar> ListarPendientes()
        {
            var lista = new List<CuentaCobrar>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select cc.id_cuenta, cc.id_venta, cc.id_cliente, cc.monto_original, cc.saldo, cc.fecha_vencimiento, cc.estado, " +
                             "v.fecha as fecha_venta, c.nombre + ' ' + c.apellido as cliente, c.cedula " +
                             "from cuentas_cobrar cc " +
                             "inner join ventas v on v.id_venta = cc.id_venta " +
                             "inner join clientes c on c.id_cliente = cc.id_cliente " +
                             "where cc.saldo > 0 " +
                             "order by cc.fecha_vencimiento";

                using (var cmd = new SqlCommand(sql, conexion))
                {
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

        public List<CuentaCobrar> ListarPorCliente(int idCliente)
        {
            var lista = new List<CuentaCobrar>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select cc.id_cuenta, cc.id_venta, cc.id_cliente, cc.monto_original, cc.saldo, cc.fecha_vencimiento, cc.estado, " +
                             "v.fecha as fecha_venta, c.nombre + ' ' + c.apellido as cliente, c.cedula " +
                             "from cuentas_cobrar cc " +
                             "inner join ventas v on v.id_venta = cc.id_venta " +
                             "inner join clientes c on c.id_cliente = cc.id_cliente " +
                             "where cc.id_cliente = @idCliente and cc.saldo > 0 " +
                             "order by cc.fecha_vencimiento";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
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

        public decimal ObtenerDeuda(int idCliente)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select isnull(sum(saldo), 0) from cuentas_cobrar where id_cliente = @idCliente";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conexion.Open();
                    return (decimal)cmd.ExecuteScalar();
                }
            }
        }

        // registra el abono, lo descuenta del saldo y deja el pago en el historial del cliente
        public void Abonar(Pago pago, int idCuenta, string concepto)
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

                        string sqlDetalle = "insert into pagos_detalle (id_pago, concepto, monto) values (@idPago, @concepto, @monto)";

                        using (var cmd = new SqlCommand(sqlDetalle, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idPago", idPago);
                            cmd.Parameters.AddWithValue("@concepto", concepto);
                            cmd.Parameters.AddWithValue("@monto", pago.MontoTotal);
                            cmd.ExecuteNonQuery();
                        }

                        string sqlAbono = "insert into abonos (id_cuenta, monto, id_usuario) values (@idCuenta, @monto, @idUsuario)";

                        using (var cmd = new SqlCommand(sqlAbono, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idCuenta", idCuenta);
                            cmd.Parameters.AddWithValue("@monto", pago.MontoTotal);
                            cmd.Parameters.AddWithValue("@idUsuario", pago.IdUsuario);
                            cmd.ExecuteNonQuery();
                        }

                        string sqlCuenta = "update cuentas_cobrar set saldo = saldo - @monto, " +
                                           "estado = case when saldo - @monto <= 0 then 'Saldada' else estado end " +
                                           "where id_cuenta = @idCuenta";

                        using (var cmd = new SqlCommand(sqlCuenta, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@monto", pago.MontoTotal);
                            cmd.Parameters.AddWithValue("@idCuenta", idCuenta);
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

        private CuentaCobrar Mapear(SqlDataReader dr)
        {
            return new CuentaCobrar
            {
                IdCuenta = (int)dr["id_cuenta"],
                IdVenta = (int)dr["id_venta"],
                IdCliente = (int)dr["id_cliente"],
                MontoOriginal = (decimal)dr["monto_original"],
                Saldo = (decimal)dr["saldo"],
                FechaVencimiento = (DateTime)dr["fecha_vencimiento"],
                Estado = dr["estado"].ToString(),
                FechaVenta = (DateTime)dr["fecha_venta"],
                Cliente = dr["cliente"].ToString(),
                Cedula = dr["cedula"].ToString()
            };
        }
    }
}
