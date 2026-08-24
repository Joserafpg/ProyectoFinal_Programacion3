using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        public List<Cliente> Listar(string texto)
        {
            return datos.Listar(texto.Trim());
        }

        // estado null = todos; membresia: "Todas", "Al día", "Vencida" o "Sin membresía"
        public List<Cliente> Listar(string texto, bool? estado, string membresia)
        {
            var lista = datos.Listar(texto.Trim());

            if (estado != null)
                lista = lista.Where(c => c.Estado == estado.Value).ToList();

            if (!string.IsNullOrEmpty(membresia) && membresia != "Todas")
                lista = lista.Where(c => c.EstadoMembresia == membresia).ToList();

            return lista;
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
