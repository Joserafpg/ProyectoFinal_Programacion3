using System.Collections.Generic;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ClienteNegocio
    {
        private ClienteDatos datos = new ClienteDatos();

        public List<Cliente> Listar()
        {
            return datos.Listar();
        }

        public List<Cliente> Buscar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return datos.Listar();

            return datos.Buscar(texto.Trim());
        }

        public string Insertar(Cliente cliente)
        {
            string error = Validar(cliente);
            if (error != "")
                return error;

            try
            {
                datos.Insertar(cliente);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un cliente con esa cédula.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Cliente cliente)
        {
            string error = Validar(cliente);
            if (error != "")
                return error;

            try
            {
                datos.Actualizar(cliente);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un cliente con esa cédula.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idCliente, bool estado)
        {
            try
            {
                datos.CambiarEstado(idCliente, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }

        private string Validar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                return "El nombre del cliente es obligatorio.";

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
                return "El apellido del cliente es obligatorio.";

            if (string.IsNullOrWhiteSpace(cliente.Cedula))
                return "La cédula del cliente es obligatoria.";

            return "";
        }

        public Cliente ObtenerPorCedula(string cedula)
        {
            return datos.ObtenerPorCedula(cedula);
        }
    }
}
