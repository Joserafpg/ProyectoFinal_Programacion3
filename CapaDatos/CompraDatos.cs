using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CompraDatos
    {
        // registra la compra con su detalle y repone el stock, todo en una transaccion
        public int Insertar(Compra compra)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int idCompra;

                        string sqlCompra = "insert into compras (id_proveedor, id_usuario, numero_factura, subtotal, impuesto, total) " +
                                           "values (@idProveedor, @idUsuario, @numeroFactura, @subtotal, @impuesto, @total) " +
                                           "select cast(scope_identity() as int)";

                        using (var cmd = new SqlCommand(sqlCompra, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@idProveedor", compra.IdProveedor);
                            cmd.Parameters.AddWithValue("@idUsuario", compra.IdUsuario);
                            cmd.Parameters.AddWithValue("@numeroFactura", string.IsNullOrWhiteSpace(compra.NumeroFactura) ? (object)DBNull.Value : compra.NumeroFactura.Trim());
                            cmd.Parameters.AddWithValue("@subtotal", compra.Subtotal);
                            cmd.Parameters.AddWithValue("@impuesto", compra.Impuesto);
                            cmd.Parameters.AddWithValue("@total", compra.Total);
                            idCompra = (int)cmd.ExecuteScalar();
                        }

                        foreach (var detalle in compra.Detalles)
                        {
                            string sqlDetalle = "insert into compra_detalle (id_compra, id_producto, cantidad, precio_compra, subtotal) " +
                                                "values (@idCompra, @idProducto, @cantidad, @precioCompra, @subtotal)";

                            using (var cmd = new SqlCommand(sqlDetalle, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idCompra", idCompra);
                                cmd.Parameters.AddWithValue("@idProducto", detalle.IdProducto);
                                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                                cmd.Parameters.AddWithValue("@precioCompra", detalle.PrecioCompra);
                                cmd.Parameters.AddWithValue("@subtotal", detalle.Subtotal);
                                cmd.ExecuteNonQuery();
                            }

                            string sqlStock = "update productos set stock = stock + @cantidad, precio_compra = @precioCompra where id_producto = @idProducto";

                            using (var cmd = new SqlCommand(sqlStock, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                                cmd.Parameters.AddWithValue("@precioCompra", detalle.PrecioCompra);
                                cmd.Parameters.AddWithValue("@idProducto", detalle.IdProducto);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                        return idCompra;
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        public List<Compra> Listar()
        {
            return Buscar(DateTime.MinValue, DateTime.MaxValue, 0, "");
        }

        // compras en un rango de fechas; idProveedor 0 = todos, factura vacia = sin filtro
        public List<Compra> Buscar(DateTime desde, DateTime hasta, int idProveedor, string factura)
        {
            var lista = new List<Compra>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select c.id_compra, c.fecha, c.id_proveedor, c.numero_factura, c.subtotal, c.impuesto, c.total, c.estado, " +
                             "p.nombre as proveedor, u.nombre_completo as usuario " +
                             "from compras c " +
                             "inner join proveedores p on p.id_proveedor = c.id_proveedor " +
                             "inner join usuarios u on u.id_usuario = c.id_usuario " +
                             "where cast(c.fecha as date) between @desde and @hasta " +
                             "and (@idProveedor = 0 or c.id_proveedor = @idProveedor) " +
                             "and (@factura = '' or c.numero_factura like @factura) " +
                             "order by c.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@desde", desde == DateTime.MinValue ? new DateTime(1900, 1, 1) : desde.Date);
                    cmd.Parameters.AddWithValue("@hasta", hasta == DateTime.MaxValue ? new DateTime(9999, 12, 31) : hasta.Date);
                    cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@factura", string.IsNullOrWhiteSpace(factura) ? "" : "%" + factura.Trim() + "%");
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra
                            {
                                IdCompra = (int)dr["id_compra"],
                                Fecha = (DateTime)dr["fecha"],
                                IdProveedor = (int)dr["id_proveedor"],
                                NumeroFactura = dr["numero_factura"] == DBNull.Value ? "" : dr["numero_factura"].ToString(),
                                Subtotal = (decimal)dr["subtotal"],
                                Impuesto = (decimal)dr["impuesto"],
                                Total = (decimal)dr["total"],
                                Estado = dr["estado"].ToString(),
                                Proveedor = dr["proveedor"].ToString(),
                                Usuario = dr["usuario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public List<CompraDetalle> ListarDetalle(int idCompra)
        {
            var lista = new List<CompraDetalle>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select d.id_compra_detalle, d.id_compra, d.id_producto, p.nombre as producto, d.cantidad, d.precio_compra, d.subtotal " +
                             "from compra_detalle d " +
                             "inner join productos p on p.id_producto = d.id_producto " +
                             "where d.id_compra = @idCompra";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CompraDetalle
                            {
                                IdCompraDetalle = (int)dr["id_compra_detalle"],
                                IdCompra = (int)dr["id_compra"],
                                IdProducto = (int)dr["id_producto"],
                                Producto = dr["producto"].ToString(),
                                Cantidad = (int)dr["cantidad"],
                                PrecioCompra = (decimal)dr["precio_compra"],
                                Subtotal = (decimal)dr["subtotal"]
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
