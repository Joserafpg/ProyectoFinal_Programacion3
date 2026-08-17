using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class HorarioNegocio
    {
        private HorarioDatos datos = new HorarioDatos();

        public List<Horario> Listar()
        {
            return datos.Listar();
        }

        public List<Horario> Listar(string texto)
        {
            return datos.Listar(texto.Trim());
        }

        public string Insertar(Horario horario)
        {
            string error = Validar(horario);
            if (error != "")
                return error;

            try
            {
                datos.Insertar(horario);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un horario con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Horario horario)
        {
            string error = Validar(horario);
            if (error != "")
                return error;

            try
            {
                datos.Actualizar(horario);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un horario con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idHorario, bool estado)
        {
            try
            {
                datos.CambiarEstado(idHorario, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }

        private string Validar(Horario horario)
        {
            if (string.IsNullOrWhiteSpace(horario.Nombre))
                return "El nombre del horario es obligatorio.";

            if (string.IsNullOrWhiteSpace(horario.Dias))
                return "Debe indicar los días del horario.";

            if (horario.HoraFin <= horario.HoraInicio)
                return "La hora final debe ser mayor que la hora de inicio.";

            return "";
        }
    }
}
