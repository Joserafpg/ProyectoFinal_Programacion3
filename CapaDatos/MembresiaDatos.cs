using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MembresiaDatos
    {
        public List<Membresia> Listar()
        {
            var lista = new List<Membresia>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_membresia, nombre, descripcion, duracion_dias, precio, fecha_creacion, estado from membresias order by duracion_dias";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Membresia
                            {
                                IdMembresia = (int)dr["id_membresia"],
                                Nombre = dr["nombre"].ToString(),
                                Descripcion = dr["descripcion"] == DBNull.Value ? "" : dr["descripcion"].ToString(),
                                DuracionDias = (int)dr["duracion_dias"],
                                Precio = (decimal)dr["precio"],
                                FechaCreacion = (DateTime)dr["fecha_creacion"],
                                Estado = (bool)dr["estado"]
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Membresia membresia)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "insert into membresias (nombre, descripcion, duracion_dias, precio) values (@nombre, @descripcion, @duracion_dias, @precio)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", membresia.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (object)membresia.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@duracion_dias", membresia.DuracionDias);
                    cmd.Parameters.AddWithValue("@precio", membresia.Precio);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Membresia membresia)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update membresias set nombre = @nombre, descripcion = @descripcion, duracion_dias = @duracion_dias, precio = @precio where id_membresia = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", membresia.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (object)membresia.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@duracion_dias", membresia.DuracionDias);
                    cmd.Parameters.AddWithValue("@precio", membresia.Precio);
                    cmd.Parameters.AddWithValue("@id", membresia.IdMembresia);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idMembresia, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update membresias set estado = @estado where id_membresia = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idMembresia);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
