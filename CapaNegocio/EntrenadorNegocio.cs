using System.Collections.Generic;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class EntrenadorNegocio
    {
        private EntrenadorDatos datos = new EntrenadorDatos();

        public List<Entrenador> Listar()
        {
            return datos.Listar();
        }

        public List<Entrenador> Listar(string texto)
        {
            return datos.Listar(texto.Trim());
        }

        public string Insertar(Entrenador entrenador)
        {
            string error = Validar(entrenador);
            if (error != "")
                return error;

            try
            {
                datos.Insertar(entrenador);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un entrenador con esa cédula.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Entrenador entrenador)
        {
            string error = Validar(entrenador);
            if (error != "")
                return error;

            try
            {
                datos.Actualizar(entrenador);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un entrenador con esa cédula.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idEntrenador, bool estado)
        {
            try
            {
                datos.CambiarEstado(idEntrenador, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }

        private string Validar(Entrenador entrenador)
        {
            if (string.IsNullOrWhiteSpace(entrenador.Nombre))
                return "El nombre del entrenador es obligatorio.";

            if (string.IsNullOrWhiteSpace(entrenador.Apellido))
                return "El apellido del entrenador es obligatorio.";

            if (string.IsNullOrWhiteSpace(entrenador.Cedula))
                return "La cédula del entrenador es obligatoria.";

            if (entrenador.IdHorario <= 0)
                return "Debe seleccionar un horario.";

            return "";
        }
    }
}
