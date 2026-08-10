using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class HorarioDatos
    {
        public List<Horario> Listar()
        {
            var lista = new List<Horario>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_horario, nombre, dias, hora_inicio, hora_fin, estado from horarios order by hora_inicio";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Horario
                            {
                                IdHorario = (int)dr["id_horario"],
                                Nombre = dr["nombre"].ToString(),
                                Dias = dr["dias"].ToString(),
                                HoraInicio = (TimeSpan)dr["hora_inicio"],
                                HoraFin = (TimeSpan)dr["hora_fin"],
                                Estado = (bool)dr["estado"]
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Horario horario)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "insert into horarios (nombre, dias, hora_inicio, hora_fin) values (@nombre, @dias, @hora_inicio, @hora_fin)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", horario.Nombre);
                    cmd.Parameters.AddWithValue("@dias", horario.Dias);
                    cmd.Parameters.AddWithValue("@hora_inicio", horario.HoraInicio);
                    cmd.Parameters.AddWithValue("@hora_fin", horario.HoraFin);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Horario horario)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update horarios set nombre = @nombre, dias = @dias, hora_inicio = @hora_inicio, hora_fin = @hora_fin where id_horario = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", horario.Nombre);
                    cmd.Parameters.AddWithValue("@dias", horario.Dias);
                    cmd.Parameters.AddWithValue("@hora_inicio", horario.HoraInicio);
                    cmd.Parameters.AddWithValue("@hora_fin", horario.HoraFin);
                    cmd.Parameters.AddWithValue("@id", horario.IdHorario);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idHorario, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update horarios set estado = @estado where id_horario = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idHorario);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
