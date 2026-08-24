using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
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
                string sql = "select p.id_pago, p.fecha, p.metodo_pago, p.monto_total, p.estado, " +
                             "isnull(stuff((select ' + ' + d.concepto from pagos_detalle d where d.id_pago = p.id_pago for xml path('')), 1, 3, ''), '') as concepto, " +
                             "c.nombre + ' ' + c.apellido as cliente, u.nombre_completo as usuario " +
                             "from pagos p " +
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
                string sql = "select p.id_pago, p.fecha, p.metodo_pago, p.monto_total, p.estado, " +
                             "isnull(stuff((select ' + ' + d.concepto from pagos_detalle d where d.id_pago = p.id_pago for xml path('')), 1, 3, ''), '') as concepto, " +
                             "c.nombre + ' ' + c.apellido as cliente, u.nombre_completo as usuario " +
                             "from pagos p " +
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

        // pagos en un rango de fechas; metodo y texto vacios = sin filtro, idCliente null = todos
        public List<Pago> Buscar(DateTime desde, DateTime hasta, string metodo, string textoCliente, int? idCliente)
        {
            var lista = new List<Pago>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select p.id_pago, p.fecha, p.metodo_pago, p.monto_total, p.estado, " +
                             "isnull(stuff((select ' + ' + d.concepto from pagos_detalle d where d.id_pago = p.id_pago for xml path('')), 1, 3, ''), '') as concepto, " +
                             "c.nombre + ' ' + c.apellido as cliente, u.nombre_completo as usuario " +
                             "from pagos p " +
                             "inner join clientes c on c.id_cliente = p.id_cliente " +
                             "inner join usuarios u on u.id_usuario = p.id_usuario " +
                             "where cast(p.fecha as date) between @desde and @hasta " +
                             "and (@metodo = '' or p.metodo_pago = @metodo) " +
                             "and (@idCliente is null or p.id_cliente = @idCliente) " +
                             "and (@texto = '' or c.nombre + ' ' + c.apellido like @texto or c.cedula like @texto) " +
                             "order by p.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@desde", desde.Date);
                    cmd.Parameters.AddWithValue("@hasta", hasta.Date);
                    cmd.Parameters.AddWithValue("@metodo", metodo ?? "");
                    cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = (object)idCliente ?? DBNull.Value;
                    cmd.Parameters.AddWithValue("@texto", string.IsNullOrWhiteSpace(textoCliente) ? "" : "%" + textoCliente.Trim() + "%");
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

        // clientes activos con credito pendiente, visitas sin pagar o membresia vencida
        public List<Deudor> ListarDeudores()
        {
            var lista = new List<Deudor>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select * from (" +
                             "select c.id_cliente, c.nombre + ' ' + c.apellido as cliente, c.cedula, " +
                             "isnull((select sum(cc.saldo) from cuentas_cobrar cc where cc.id_cliente = c.id_cliente and cc.saldo > 0), 0) as credito, " +
                             "(select count(*) from visitas v where v.id_cliente = c.id_cliente and v.estado = 'Pendiente') as visitas, " +
                             "isnull((select sum(v.monto) from visitas v where v.id_cliente = c.id_cliente and v.estado = 'Pendiente'), 0) as monto_visitas, " +
                             "(select top 1 m.nombre from cliente_membresia cm inner join membresias m on m.id_membresia = cm.id_membresia " +
                             " where cm.id_cliente = c.id_cliente order by cm.fecha_fin desc) as ultimo_plan, " +
                             "(select max(cm.fecha_fin) from cliente_membresia cm where cm.id_cliente = c.id_cliente) as ultimo_vence " +
                             "from clientes c where c.estado = 1) d " +
                             "where d.credito > 0 or d.visitas > 0 or (d.ultimo_vence is not null and d.ultimo_vence < cast(getdate() as date)) " +
                             "order by d.credito + d.monto_visitas desc, d.cliente";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Deudor
                            {
                                IdCliente = (int)dr["id_cliente"],
                                Cliente = dr["cliente"].ToString(),
                                Cedula = dr["cedula"].ToString(),
                                Credito = (decimal)dr["credito"],
                                VisitasPendientes = (int)dr["visitas"],
                                MontoVisitas = (decimal)dr["monto_visitas"],
                                UltimoPlan = dr["ultimo_plan"] == DBNull.Value ? "" : dr["ultimo_plan"].ToString(),
                                UltimoVencimiento = dr["ultimo_vence"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["ultimo_vence"]
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public List<PagoDetalle> ListarDetalle(int idPago)
        {
            var lista = new List<PagoDetalle>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_pago, concepto, monto from pagos_detalle where id_pago = @idPago";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idPago", idPago);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new PagoDetalle
                            {
                                IdPago = (int)dr["id_pago"],
                                Concepto = dr["concepto"].ToString(),
                                Monto = (decimal)dr["monto"]
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

                            // la entrada ya se registro en el check-in; aqui solo se salda la visita
                            if (item.Visita != null)
                            {
                                string sqlVisita = "update visitas set estado = 'Pagada', id_pago = @idPago " +
                                                   "where id_visita = @idVisita and estado = 'Pendiente'";

                                using (var cmd = new SqlCommand(sqlVisita, conexion, transaccion))
                                {
                                    cmd.Parameters.AddWithValue("@idPago", idPago);
                                    cmd.Parameters.AddWithValue("@idVisita", item.Visita.IdVisita);

                                    if (cmd.ExecuteNonQuery() != 1)
                                        throw new InvalidOperationException("La visita del " + item.Visita.Fecha.ToString("dd/MM/yyyy") + " ya fue cobrada.");
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
