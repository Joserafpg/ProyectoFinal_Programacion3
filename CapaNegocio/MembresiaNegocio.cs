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
    public class MembresiaNegocio
    {
        private MembresiaDatos datos = new MembresiaDatos();

        public List<Membresia> Listar()
        {
            return datos.Listar();
        }

        public List<Membresia> Listar(string texto)
        {
            return datos.Listar(texto.Trim());
        }

        public string Insertar(Membresia membresia)
        {
            string error = Validar(membresia);
            if (error != "")
                return error;

            try
            {
                datos.Insertar(membresia);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe una membresia con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Membresia membresia)
        {
            string error = Validar(membresia);
            if (error != "")
                return error;

            try
            {
                datos.Actualizar(membresia);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe una membresia con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idMembresia, bool estado)
        {
            try
            {
                datos.CambiarEstado(idMembresia, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }

        private string Validar(Membresia membresia)
        {
            if (string.IsNullOrWhiteSpace(membresia.Nombre))
                return "El nombre de la membresía es obligatorio.";

            if (membresia.DuracionDias <= 0)
                return "La duración debe ser mayor que cero días.";

            if (membresia.Precio < 0)
                return "El precio no puede ser negativo.";

            return "";
        }
    }
}
