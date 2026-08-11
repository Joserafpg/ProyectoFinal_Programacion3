using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentaDatos
    {
        public int Insertar(Venta venta)
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
