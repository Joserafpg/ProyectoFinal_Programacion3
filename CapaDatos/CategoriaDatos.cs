using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CategoriaDatos
    {
        public List<Categoria> Listar()
        {
            var lista = new List<Categoria>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_categoria, nombre, descripcion, estado from categorias order by nombre";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria
                            {
                                IdCategoria = (int)dr["id_categoria"],
                                Nombre = dr["nombre"].ToString(),
                                Descripcion = dr["descripcion"] == DBNull.Value ? "" : dr["descripcion"].ToString(),
                                Estado = (bool)dr["estado"]
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Categoria categoria)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "insert into categorias (nombre, descripcion) values (@nombre, @descripcion)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (object)categoria.Descripcion ?? DBNull.Value);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Categoria categoria)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update categorias set nombre = @nombre, descripcion = @descripcion where id_categoria = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (object)categoria.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", categoria.IdCategoria);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idCategoria, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update categorias set estado = @estado where id_categoria = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idCategoria);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
