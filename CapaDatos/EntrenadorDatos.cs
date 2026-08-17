using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class EntrenadorDatos
    {
        public List<Entrenador> Listar()
        {
            return Listar("");
        }

        public List<Entrenador> Listar(string texto)
        {
            var lista = new List<Entrenador>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"select e.id_entrenador, e.nombre, e.apellido, e.cedula, e.telefono, e.correo,
                               e.especialidad, e.id_horario, e.estado, h.nombre as horario
                               from entrenadores e
                               inner join horarios h on h.id_horario = e.id_horario
                               where e.nombre like @texto or e.apellido like @texto or e.cedula like @texto
                               order by e.nombre, e.apellido";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Entrenador
                            {
                                IdEntrenador = (int)dr["id_entrenador"],
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString(),
                                Cedula = dr["cedula"].ToString(),
                                Telefono = dr["telefono"] == DBNull.Value ? "" : dr["telefono"].ToString(),
                                Correo = dr["correo"] == DBNull.Value ? "" : dr["correo"].ToString(),
                                Especialidad = dr["especialidad"] == DBNull.Value ? "" : dr["especialidad"].ToString(),
                                IdHorario = (int)dr["id_horario"],
                                Estado = (bool)dr["estado"],
                                Horario = dr["horario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Entrenador entrenador)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"insert into entrenadores (nombre, apellido, cedula, telefono, correo, especialidad, id_horario)
                               values (@nombre, @apellido, @cedula, @telefono, @correo, @especialidad, @id_horario)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", entrenador.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", entrenador.Apellido);
                    cmd.Parameters.AddWithValue("@cedula", entrenador.Cedula);
                    cmd.Parameters.AddWithValue("@telefono", (object)entrenador.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@correo", (object)entrenador.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@especialidad", (object)entrenador.Especialidad ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_horario", entrenador.IdHorario);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Entrenador entrenador)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"update entrenadores set nombre = @nombre, apellido = @apellido, cedula = @cedula,
                               telefono = @telefono, correo = @correo, especialidad = @especialidad, id_horario = @id_horario
                               where id_entrenador = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", entrenador.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", entrenador.Apellido);
                    cmd.Parameters.AddWithValue("@cedula", entrenador.Cedula);
                    cmd.Parameters.AddWithValue("@telefono", (object)entrenador.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@correo", (object)entrenador.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@especialidad", (object)entrenador.Especialidad ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_horario", entrenador.IdHorario);
                    cmd.Parameters.AddWithValue("@id", entrenador.IdEntrenador);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idEntrenador, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update entrenadores set estado = @estado where id_entrenador = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idEntrenador);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
