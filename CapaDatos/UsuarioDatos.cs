using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class UsuarioDatos
    {

        public Usuario ObtenerPorNombreUsuario(string nombreUsuario)
        {
            Usuario usuario = null;

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"select u.id_usuario, u.id_rol, u.nombre_usuario, u.clave, u.nombre_completo,
                               u.correo, u.fecha_creacion, u.estado, r.nombre as nombre_rol
                               from usuarios u
                               inner join roles r on r.id_rol = u.id_rol
                               where u.nombre_usuario = @nombre_usuario";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new Usuario
                            {
                                IdUsuario = (int)dr["id_usuario"],
                                IdRol = (int)dr["id_rol"],
                                NombreUsuario = dr["nombre_usuario"].ToString(),
                                Clave = dr["clave"].ToString(),
                                NombreCompleto = dr["nombre_completo"].ToString(),
                                Correo = dr["correo"] == DBNull.Value ? "" : dr["correo"].ToString(),
                                FechaCreacion = (DateTime)dr["fecha_creacion"],
                                Estado = (bool)dr["estado"],
                                NombreRol = dr["nombre_rol"].ToString()
                            };
                        }
                    }
                }
            }

            return usuario;
        }

        public List<string> ObtenerPermisos(int idRol)
        {
            var permisos = new List<string>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"select p.nombre
                               from rol_permiso rp
                               inner join permisos p on p.id_permiso = rp.id_permiso
                               where rp.id_rol = @id_rol";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            permisos.Add(dr["nombre"].ToString());
                    }
                }
            }

            return permisos;
        }

        public List<Usuario> Listar()
        {
            return Listar("");
        }

        public List<Usuario> Listar(string texto)
        {
            var lista = new List<Usuario>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"select u.id_usuario, u.id_rol, u.nombre_usuario, u.nombre_completo,
                               u.correo, u.fecha_creacion, u.estado, r.nombre as nombre_rol
                               from usuarios u
                               inner join roles r on r.id_rol = u.id_rol
                               where u.nombre_usuario like @texto or u.nombre_completo like @texto
                               order by u.nombre_usuario";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario
                            {
                                IdUsuario = (int)dr["id_usuario"],
                                IdRol = (int)dr["id_rol"],
                                NombreUsuario = dr["nombre_usuario"].ToString(),
                                Clave = "",
                                NombreCompleto = dr["nombre_completo"].ToString(),
                                Correo = dr["correo"] == DBNull.Value ? "" : dr["correo"].ToString(),
                                FechaCreacion = (DateTime)dr["fecha_creacion"],
                                Estado = (bool)dr["estado"],
                                NombreRol = dr["nombre_rol"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Usuario usuario)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"insert into usuarios (id_rol, nombre_usuario, clave, nombre_completo, correo)
                               values (@id_rol, @nombre_usuario, @clave, @nombre_completo, @correo)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                    cmd.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@clave", usuario.Clave);
                    cmd.Parameters.AddWithValue("@nombre_completo", usuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("@correo", (object)usuario.Correo ?? DBNull.Value);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Usuario usuario)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"update usuarios set id_rol = @id_rol, nombre_usuario = @nombre_usuario,
                               nombre_completo = @nombre_completo, correo = @correo
                               where id_usuario = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                    cmd.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@nombre_completo", usuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("@correo", (object)usuario.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", usuario.IdUsuario);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarClave(int idUsuario, string claveHash)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update usuarios set clave = @clave where id_usuario = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@clave", claveHash);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idUsuario, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update usuarios set estado = @estado where id_usuario = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
