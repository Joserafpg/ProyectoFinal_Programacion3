using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProveedorDatos
    {
        public List<Proveedor> Listar()
        {
            var lista = new List<Proveedor>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "select id_proveedor, nombre, rnc, telefono, correo, direccion, fecha_creacion, estado from proveedores order by nombre";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor
                            {
                                IdProveedor = (int)dr["id_proveedor"],
                                Nombre = dr["nombre"].ToString(),
                                Rnc = dr["rnc"] == DBNull.Value ? "" : dr["rnc"].ToString(),
                                Telefono = dr["telefono"] == DBNull.Value ? "" : dr["telefono"].ToString(),
                                Correo = dr["correo"] == DBNull.Value ? "" : dr["correo"].ToString(),
                                Direccion = dr["direccion"] == DBNull.Value ? "" : dr["direccion"].ToString(),
                                FechaCreacion = (DateTime)dr["fecha_creacion"],
                                Estado = (bool)dr["estado"]
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(Proveedor proveedor)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "insert into proveedores (nombre, rnc, telefono, correo, direccion) values (@nombre, @rnc, @telefono, @correo, @direccion)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                    cmd.Parameters.AddWithValue("@rnc", (object)proveedor.Rnc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@telefono", (object)proveedor.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@correo", (object)proveedor.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@direccion", (object)proveedor.Direccion ?? DBNull.Value);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Proveedor proveedor)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update proveedores set nombre = @nombre, rnc = @rnc, telefono = @telefono, correo = @correo, direccion = @direccion where id_proveedor = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                    cmd.Parameters.AddWithValue("@rnc", (object)proveedor.Rnc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@telefono", (object)proveedor.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@correo", (object)proveedor.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@direccion", (object)proveedor.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", proveedor.IdProveedor);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idProveedor, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update proveedores set estado = @estado where id_proveedor = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idProveedor);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
