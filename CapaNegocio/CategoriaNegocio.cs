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
    public class CategoriaNegocio
    {
        private CategoriaDatos datos = new CategoriaDatos();

        public List<Categoria> Listar()
        {
            return datos.Listar();
        }

        public string Insertar(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                return "El nombre de la categoría es obligatorio.";

            try
            {
                datos.Insertar(categoria);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe una categoría con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                return "El nombre de la categoría es obligatorio.";

            try
            {
                datos.Actualizar(categoria);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe una categoría con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idCategoria, bool estado)
        {
            try
            {
                datos.CambiarEstado(idCategoria, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }
    }
}
