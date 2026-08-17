using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AsistenciaDatos
    {
        public void Registrar(int idCliente)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "insert into asistencia (id_cliente) values (@idCliente)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool YaEntroHoy(int idCliente)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select count(*) from asistencia where id_cliente = @idCliente and cast(fecha as date) = cast(getdate() as date)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conexion.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public List<Asistencia> ListarHoy()
        {
            var lista = new List<Asistencia>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select a.id_asistencia, a.id_cliente, a.fecha, c.nombre + ' ' + c.apellido as cliente " +
                             "from asistencia a " +
                             "inner join clientes c on c.id_cliente = a.id_cliente " +
                             "where cast(a.fecha as date) = cast(getdate() as date) " +
                             "order by a.fecha desc";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Asistencia
                            {
                                IdAsistencia = (int)dr["id_asistencia"],
                                IdCliente = (int)dr["id_cliente"],
                                Fecha = (DateTime)dr["fecha"],
                                Cliente = dr["cliente"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
