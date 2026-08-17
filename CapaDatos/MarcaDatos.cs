using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MarcaDatos
    {
        public List<Marca> Listar()
        {
            return Listar("");
        }

        public List<Marca> Listar(string texto)
        {
            var lista = new List<Marca>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_marca, nombre, estado from marcas where nombre like @texto order by nombre";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Marca
                            {
                                IdMarca = (int)dr["id_marca"],
                                Nombre = dr["nombre"].ToString(),
                                Estado = (bool)dr["estado"]
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Marca marca)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "insert into marcas (nombre) values (@nombre)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", marca.Nombre);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Marca marca)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update marcas set nombre = @nombre where id_marca = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", marca.Nombre);
                    cmd.Parameters.AddWithValue("@id", marca.IdMarca);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idMarca, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update marcas set estado = @estado where id_marca = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idMarca);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}