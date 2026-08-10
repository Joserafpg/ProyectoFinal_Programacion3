using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

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
    }
}
