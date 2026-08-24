using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ProductoDatos
    {
        public List<Producto> Listar()
        {
            return Listar("");
        }

        public List<Producto> Listar(string texto)
        {
            var lista = new List<Producto>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"select p.id_producto, p.codigo, p.codigo_barras, p.nombre, p.descripcion,
                               p.id_categoria, p.id_marca, p.precio_compra, p.precio_venta,
                               p.stock, p.stock_minimo, p.imagen, p.estado,
                               c.nombre as categoria, m.nombre as marca
                               from productos p
                               inner join categorias c on c.id_categoria = p.id_categoria
                               inner join marcas m on m.id_marca = p.id_marca
                               where p.codigo like @texto or p.nombre like @texto
                               order by p.nombre";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto
                            {
                                IdProducto = (int)dr["id_producto"],
                                Codigo = dr["codigo"].ToString(),
                                CodigoBarras = dr["codigo_barras"] == DBNull.Value ? "" : dr["codigo_barras"].ToString(),
                                Nombre = dr["nombre"].ToString(),
                                Descripcion = dr["descripcion"] == DBNull.Value ? "" : dr["descripcion"].ToString(),
                                IdCategoria = (int)dr["id_categoria"],
                                IdMarca = (int)dr["id_marca"],
                                PrecioCompra = (decimal)dr["precio_compra"],
                                PrecioVenta = (decimal)dr["precio_venta"],
                                Stock = (int)dr["stock"],
                                StockMinimo = (int)dr["stock_minimo"],
                                Imagen = dr["imagen"] == DBNull.Value ? null : (byte[])dr["imagen"],
                                Estado = (bool)dr["estado"],
                                NombreCategoria = dr["categoria"].ToString(),
                                NombreMarca = dr["marca"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Producto producto)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"insert into productos (codigo, codigo_barras, nombre, descripcion, id_categoria, id_marca,
                               precio_compra, precio_venta, stock, stock_minimo, imagen)
                               values (@codigo, @codigo_barras, @nombre, @descripcion, @id_categoria, @id_marca,
                               @precio_compra, @precio_venta, @stock, @stock_minimo, @imagen)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    AgregarParametros(cmd, producto);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Producto producto)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                // el stock no se toca aqui: solo lo mueven las ventas y las compras
                string sql = @"update productos set codigo = @codigo, codigo_barras = @codigo_barras, nombre = @nombre,
                               descripcion = @descripcion, id_categoria = @id_categoria, id_marca = @id_marca,
                               precio_compra = @precio_compra, precio_venta = @precio_venta,
                               stock_minimo = @stock_minimo, imagen = @imagen
                               where id_producto = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    AgregarParametros(cmd, producto);
                    cmd.Parameters.AddWithValue("@id", producto.IdProducto);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idProducto, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update productos set estado = @estado where id_producto = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void AgregarParametros(SqlCommand cmd, Producto producto)
        {
            cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
            cmd.Parameters.AddWithValue("@codigo_barras", string.IsNullOrWhiteSpace(producto.CodigoBarras) ? (object)DBNull.Value : producto.CodigoBarras);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", (object)producto.Descripcion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id_categoria", producto.IdCategoria);
            cmd.Parameters.AddWithValue("@id_marca", producto.IdMarca);
            cmd.Parameters.AddWithValue("@precio_compra", producto.PrecioCompra);
            cmd.Parameters.AddWithValue("@precio_venta", producto.PrecioVenta);
            cmd.Parameters.AddWithValue("@stock", producto.Stock);
            cmd.Parameters.AddWithValue("@stock_minimo", producto.StockMinimo);
            cmd.Parameters.Add("@imagen", SqlDbType.VarBinary, -1).Value = (object)producto.Imagen ?? DBNull.Value;
        }
    }
}
