using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class RolDatos
    {
        public List<Rol> Listar()
        {
            var lista = new List<Rol>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_rol, nombre, descripcion, estado from roles order by nombre";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol
                            {
                                IdRol = (int)dr["id_rol"],
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

        public void Insertar(Rol rol)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "insert into roles (nombre, descripcion) values (@nombre, @descripcion)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (object)rol.Descripcion ?? DBNull.Value);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Rol rol)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update roles set nombre = @nombre, descripcion = @descripcion where id_rol = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (object)rol.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", rol.IdRol);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idRol, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update roles set estado = @estado where id_rol = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idRol);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
