using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ClaseDatos
    {
        public List<Clase> Listar()
        {
            var lista = new List<Clase>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"select c.id_clase, c.nombre, c.descripcion, c.id_entrenador, c.dia_semana,
                               c.hora_inicio, c.hora_fin, c.cupo_maximo, c.estado,
                               e.nombre + ' ' + e.apellido as entrenador
                               from clases c
                               inner join entrenadores e on e.id_entrenador = c.id_entrenador
                               order by c.nombre";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Clase
                            {
                                IdClase = (int)dr["id_clase"],
                                Nombre = dr["nombre"].ToString(),
                                Descripcion = dr["descripcion"] == DBNull.Value ? "" : dr["descripcion"].ToString(),
                                IdEntrenador = (int)dr["id_entrenador"],
                                DiaSemana = dr["dia_semana"].ToString(),
                                HoraInicio = (TimeSpan)dr["hora_inicio"],
                                HoraFin = (TimeSpan)dr["hora_fin"],
                                CupoMaximo = (int)dr["cupo_maximo"],
                                Estado = (bool)dr["estado"],
                                NombreEntrenador = dr["entrenador"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Clase clase)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"insert into clases (nombre, descripcion, id_entrenador, dia_semana, hora_inicio, hora_fin, cupo_maximo)
                               values (@nombre, @descripcion, @id_entrenador, @dia_semana, @hora_inicio, @hora_fin, @cupo_maximo)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", clase.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (object)clase.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_entrenador", clase.IdEntrenador);
                    cmd.Parameters.AddWithValue("@dia_semana", clase.DiaSemana);
                    cmd.Parameters.AddWithValue("@hora_inicio", clase.HoraInicio);
                    cmd.Parameters.AddWithValue("@hora_fin", clase.HoraFin);
                    cmd.Parameters.AddWithValue("@cupo_maximo", clase.CupoMaximo);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Clase clase)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"update clases set nombre = @nombre, descripcion = @descripcion, id_entrenador = @id_entrenador,
                               dia_semana = @dia_semana, hora_inicio = @hora_inicio, hora_fin = @hora_fin, cupo_maximo = @cupo_maximo
                               where id_clase = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", clase.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", (object)clase.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_entrenador", clase.IdEntrenador);
                    cmd.Parameters.AddWithValue("@dia_semana", clase.DiaSemana);
                    cmd.Parameters.AddWithValue("@hora_inicio", clase.HoraInicio);
                    cmd.Parameters.AddWithValue("@hora_fin", clase.HoraFin);
                    cmd.Parameters.AddWithValue("@cupo_maximo", clase.CupoMaximo);
                    cmd.Parameters.AddWithValue("@id", clase.IdClase);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idClase, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update clases set estado = @estado where id_clase = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idClase);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
