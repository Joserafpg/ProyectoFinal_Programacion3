using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ClaseNegocio
    {
        private ClaseDatos datos = new ClaseDatos();

        public List<Clase> Listar()
        {
            return datos.Listar();
        }

        public List<Clase> Listar(string texto)
        {
            return datos.Listar(texto.Trim());
        }

        public List<Clase> Listar(string texto, bool? estado)
        {
            var lista = datos.Listar(texto.Trim());
            return estado == null ? lista : lista.Where(c => c.Estado == estado.Value).ToList();
        }

        public string Insertar(Clase clase)
        {
            string error = Validar(clase);
            if (error != "")
                return error;

            try
            {
                datos.Insertar(clase);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Clase clase)
        {
            string error = Validar(clase);
            if (error != "")
                return error;

            try
            {
                datos.Actualizar(clase);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idClase, bool estado)
        {
            try
            {
                datos.CambiarEstado(idClase, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }

        private string Validar(Clase clase)
        {
            if (string.IsNullOrWhiteSpace(clase.Nombre))
                return "El nombre de la clase es obligatorio.";

            if (clase.IdEntrenador <= 0)
                return "Debe seleccionar un entrenador.";

            if (string.IsNullOrWhiteSpace(clase.DiaSemana))
                return "Debe indicar el día de la clase.";

            if (clase.HoraFin <= clase.HoraInicio)
                return "La hora final debe ser mayor que la hora de inicio.";

            if (clase.CupoMaximo <= 0)
                return "El cupo debe ser mayor que cero.";

            return "";
        }
    }
}
