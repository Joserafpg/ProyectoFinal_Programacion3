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
    public class VentaDatos
    {
        public int Insertar(Venta venta, int diasCredito)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int idVenta;

                        string sqlVenta = "insert into ventas (id_cliente, id_usuario, tipo_pago, subtotal, descuento, impuesto, total) " +
                                          "values (@idCliente, @idUsuario, @tipoPago, @subtotal, @descuento, @impuesto, @total) " +
                                          "select cast(scope_identity() as int)";

                        using (var cmd = new SqlCommand(sqlVenta, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", (object)venta.IdCliente ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@idUsuario", venta.IdUsuario);
                            cmd.Parameters.AddWithValue("@tipoPago", venta.TipoPago);
                            cmd.Parameters.AddWithValue("@subtotal", venta.Subtotal);
                            cmd.Parameters.AddWithValue("@descuento", venta.Descuento);
                            cmd.Parameters.AddWithValue("@impuesto", venta.Impuesto);
                            cmd.Parameters.AddWithValue("@total", venta.Total);
                            idVenta = (int)cmd.ExecuteScalar();
                        }

                        foreach (var detalle in venta.Detalles)
                        {
                            string sqlDetalle = "insert into venta_detalle (id_venta, id_producto, cantidad, precio, descuento, subtotal) " +
                                                "values (@idVenta, @idProducto, @cantidad, @precio, @descuento, @subtotal)";

                            using (var cmd = new SqlCommand(sqlDetalle, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                                cmd.Parameters.AddWithValue("@idProducto", detalle.IdProducto);
                                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                                cmd.Parameters.AddWithValue("@precio", detalle.Precio);
                                cmd.Parameters.AddWithValue("@descuento", detalle.Descuento);
                                cmd.Parameters.AddWithValue("@subtotal", detalle.Subtotal);
                                cmd.ExecuteNonQuery();
                            }

                            string sqlStock = "update productos set stock = stock - @cantidad where id_producto = @idProducto";

                            using (var cmd = new SqlCommand(sqlStock, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                                cmd.Parameters.AddWithValue("@idProducto", detalle.IdProducto);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        if (venta.TipoPago == "Credito")
                        {
                            string sqlCuenta = "insert into cuentas_cobrar (id_venta, id_cliente, monto_original, saldo, fecha_vencimiento) " +
                                               "values (@idVenta, @idCliente, @total, @total, dateadd(day, @dias, cast(getdate() as date)))";

                            using (var cmd = new SqlCommand(sqlCuenta, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                                cmd.Parameters.AddWithValue("@idCliente", venta.IdCliente);
                                cmd.Parameters.AddWithValue("@total", venta.Total);
                                cmd.Parameters.AddWithValue("@dias", diasCredito);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                        return idVenta;
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        public List<Venta> ListarPorCliente(int idCliente)
        {
            var lista = new List<Venta>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select v.id_venta, v.fecha, v.tipo_pago, v.subtotal, v.descuento, v.impuesto, v.total, v.estado, " +
                             "isnull(c.nombre + ' ' + c.apellido, 'Consumidor final') as cliente, u.nombre_completo as usuario " +
                             "from ventas v " +
                             "left join clientes c on c.id_cliente = v.id_cliente " +
                             "inner join usuarios u on u.id_usuario = v.id_usuario " +
                             "where v.id_cliente = @idCliente " +
                             "order by v.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta
                            {
                                IdVenta = (int)dr["id_venta"],
                                Fecha = (DateTime)dr["fecha"],
                                TipoPago = dr["tipo_pago"].ToString(),
                                Subtotal = (decimal)dr["subtotal"],
                                Descuento = (decimal)dr["descuento"],
                                Impuesto = (decimal)dr["impuesto"],
                                Total = (decimal)dr["total"],
                                Estado = dr["estado"].ToString(),
                                Cliente = dr["cliente"].ToString(),
                                Usuario = dr["usuario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public List<VentaDetalle> ListarDetalle(int idVenta)
        {
            var lista = new List<VentaDetalle>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select d.id_detalle, d.id_venta, d.id_producto, p.nombre as producto, d.cantidad, d.precio, d.descuento, d.subtotal " +
                             "from venta_detalle d " +
                             "inner join productos p on p.id_producto = d.id_producto " +
                             "where d.id_venta = @idVenta";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new VentaDetalle
                            {
                                IdDetalle = (int)dr["id_detalle"],
                                IdVenta = (int)dr["id_venta"],
                                IdProducto = (int)dr["id_producto"],
                                Producto = dr["producto"].ToString(),
                                Cantidad = (int)dr["cantidad"],
                                Precio = (decimal)dr["precio"],
                                Descuento = (decimal)dr["descuento"],
                                Subtotal = (decimal)dr["subtotal"]
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public List<Venta> ListarPorFecha(DateTime desde, DateTime hasta)
        {
            var lista = new List<Venta>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select v.id_venta, v.fecha, v.tipo_pago, v.subtotal, v.descuento, v.impuesto, v.total, v.estado, " +
                             "isnull(c.nombre + ' ' + c.apellido, 'Consumidor final') as cliente, u.nombre_completo as usuario " +
                             "from ventas v " +
                             "left join clientes c on c.id_cliente = v.id_cliente " +
                             "inner join usuarios u on u.id_usuario = v.id_usuario " +
                             "where cast(v.fecha as date) between @desde and @hasta " +
                             "order by v.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@desde", desde.Date);
                    cmd.Parameters.AddWithValue("@hasta", hasta.Date);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta
                            {
                                IdVenta = (int)dr["id_venta"],
                                Fecha = (DateTime)dr["fecha"],
                                TipoPago = dr["tipo_pago"].ToString(),
                                Subtotal = (decimal)dr["subtotal"],
                                Descuento = (decimal)dr["descuento"],
                                Impuesto = (decimal)dr["impuesto"],
                                Total = (decimal)dr["total"],
                                Estado = dr["estado"].ToString(),
                                Cliente = dr["cliente"].ToString(),
                                Usuario = dr["usuario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        // ventas en un rango de fechas; tipoPago y texto vacios = sin filtro, idCliente null = todos
        public List<Venta> Buscar(DateTime desde, DateTime hasta, string tipoPago, string textoCliente, int? idCliente)
        {
            var lista = new List<Venta>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select v.id_venta, v.fecha, v.tipo_pago, v.subtotal, v.descuento, v.impuesto, v.total, v.estado, " +
                             "isnull(c.nombre + ' ' + c.apellido, 'Consumidor final') as cliente, u.nombre_completo as usuario " +
                             "from ventas v " +
                             "left join clientes c on c.id_cliente = v.id_cliente " +
                             "inner join usuarios u on u.id_usuario = v.id_usuario " +
                             "where cast(v.fecha as date) between @desde and @hasta " +
                             "and (@tipoPago = '' or v.tipo_pago = @tipoPago) " +
                             "and (@idCliente is null or v.id_cliente = @idCliente) " +
                             "and (@texto = '' or isnull(c.nombre + ' ' + c.apellido, 'Consumidor final') like @texto) " +
                             "order by v.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@desde", desde.Date);
                    cmd.Parameters.AddWithValue("@hasta", hasta.Date);
                    cmd.Parameters.AddWithValue("@tipoPago", tipoPago ?? "");
                    cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = (object)idCliente ?? DBNull.Value;
                    cmd.Parameters.AddWithValue("@texto", string.IsNullOrWhiteSpace(textoCliente) ? "" : "%" + textoCliente.Trim() + "%");
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta
                            {
                                IdVenta = (int)dr["id_venta"],
                                Fecha = (DateTime)dr["fecha"],
                                TipoPago = dr["tipo_pago"].ToString(),
                                Subtotal = (decimal)dr["subtotal"],
                                Descuento = (decimal)dr["descuento"],
                                Impuesto = (decimal)dr["impuesto"],
                                Total = (decimal)dr["total"],
                                Estado = dr["estado"].ToString(),
                                Cliente = dr["cliente"].ToString(),
                                Usuario = dr["usuario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public List<Venta> Listar()
        {
            var lista = new List<Venta>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select v.id_venta, v.fecha, v.tipo_pago, v.subtotal, v.descuento, v.impuesto, v.total, v.estado, " +
                             "isnull(c.nombre + ' ' + c.apellido, 'Consumidor final') as cliente, u.nombre_completo as usuario " +
                             "from ventas v " +
                             "left join clientes c on c.id_cliente = v.id_cliente " +
                             "inner join usuarios u on u.id_usuario = v.id_usuario " +
                             "order by v.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta
                            {
                                IdVenta = (int)dr["id_venta"],
                                Fecha = (DateTime)dr["fecha"],
                                TipoPago = dr["tipo_pago"].ToString(),
                                Subtotal = (decimal)dr["subtotal"],
                                Descuento = (decimal)dr["descuento"],
                                Impuesto = (decimal)dr["impuesto"],
                                Total = (decimal)dr["total"],
                                Estado = dr["estado"].ToString(),
                                Cliente = dr["cliente"].ToString(),
                                Usuario = dr["usuario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
