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
    public class MarcaNegocio
    {
        private MarcaDatos datos = new MarcaDatos();

        public List<Marca> Listar()
        {
            return datos.Listar();
        }

        public List<Marca> Listar(string texto)
        {
            return datos.Listar(texto.Trim());
        }

        public string Insertar(Marca marca)
        {
            if (string.IsNullOrWhiteSpace(marca.Nombre))
                return "El nombre de la marca es obligatorio.";

            try
            {
                datos.Insertar(marca);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe una marca con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Marca marca)
        {
            if (string.IsNullOrWhiteSpace(marca.Nombre))
                return "El nombre de la marca es obligatorio.";

            try
            {
                datos.Actualizar(marca);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe una marca con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idMarca, bool estado)
        {
            try
            {
                datos.CambiarEstado(idMarca, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }
    }
}
