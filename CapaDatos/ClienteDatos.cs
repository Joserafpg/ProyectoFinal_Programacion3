using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ClienteDatos
    {
        public List<Cliente> Listar()
        {
            var lista = new List<Cliente>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"select id_cliente, nombre, apellido, cedula, telefono, correo, direccion,
                               fecha_nacimiento, sexo, foto, fecha_registro, estado
                               from clientes order by nombre, apellido";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            lista.Add(Mapear(dr));
                    }
                }
            }

            return lista;
        }

        public List<Cliente> Buscar(string texto)
        {
            var lista = new List<Cliente>();

            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"select id_cliente, nombre, apellido, cedula, telefono, correo, direccion,
                               fecha_nacimiento, sexo, foto, fecha_registro, estado
                               from clientes
                               where nombre like @texto or apellido like @texto or cedula like @texto
                               order by nombre, apellido";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                    conexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            lista.Add(Mapear(dr));
                    }
                }
            }

            return lista;
        }

        public void Insertar(Cliente cliente)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"insert into clientes (nombre, apellido, cedula, telefono, correo, direccion, fecha_nacimiento, sexo, foto)
                               values (@nombre, @apellido, @cedula, @telefono, @correo, @direccion, @fecha_nacimiento, @sexo, @foto)";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    AgregarParametros(cmd, cliente);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Cliente cliente)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = @"update clientes set nombre = @nombre, apellido = @apellido, cedula = @cedula,
                               telefono = @telefono, correo = @correo, direccion = @direccion,
                               fecha_nacimiento = @fecha_nacimiento, sexo = @sexo, foto = @foto
                               where id_cliente = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    AgregarParametros(cmd, cliente);
                    cmd.Parameters.AddWithValue("@id", cliente.IdCliente);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int idCliente, bool estado)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                string sql = "update clientes set estado = @estado where id_cliente = @id";

                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void AgregarParametros(SqlCommand cmd, Cliente cliente)
        {
            cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
            cmd.Parameters.AddWithValue("@cedula", cliente.Cedula);
            cmd.Parameters.AddWithValue("@telefono", (object)cliente.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@correo", (object)cliente.Correo ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@direccion", (object)cliente.Direccion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", (object)cliente.FechaNacimiento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@sexo", (object)cliente.Sexo ?? DBNull.Value);
            cmd.Parameters.Add("@foto", SqlDbType.VarBinary, -1).Value = (object)cliente.Foto ?? DBNull.Value;
        }

        private Cliente Mapear(SqlDataReader dr)
        {
            return new Cliente
            {
                IdCliente = (int)dr["id_cliente"],
                Nombre = dr["nombre"].ToString(),
                Apellido = dr["apellido"].ToString(),
                Cedula = dr["cedula"].ToString(),
                Telefono = dr["telefono"] == DBNull.Value ? "" : dr["telefono"].ToString(),
                Correo = dr["correo"] == DBNull.Value ? "" : dr["correo"].ToString(),
                Direccion = dr["direccion"] == DBNull.Value ? "" : dr["direccion"].ToString(),
                FechaNacimiento = dr["fecha_nacimiento"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["fecha_nacimiento"],
                Sexo = dr["sexo"] == DBNull.Value ? "" : dr["sexo"].ToString(),
                Foto = dr["foto"] == DBNull.Value ? null : (byte[])dr["foto"],
                FechaRegistro = (DateTime)dr["fecha_registro"],
                Estado = (bool)dr["estado"]
            };
        }
    }
}
