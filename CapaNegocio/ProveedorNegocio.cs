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
    public class ProveedorNegocio
    {
        private ProveedorDatos datos = new ProveedorDatos();

        public List<Proveedor> Listar()
        {
            return datos.Listar();
        }

        public string Insertar(Proveedor proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.Nombre))
                return "El nombre del proveedor es obligatorio.";

            try
            {
                datos.Insertar(proveedor);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un proveedor con ese RNC.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Proveedor proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.Nombre))
                return "El nombre del proveedor es obligatorio.";

            try
            {
                datos.Actualizar(proveedor);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un proveedor con ese RNC.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idProveedor, bool estado)
        {
            try
            {
                datos.CambiarEstado(idProveedor, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }
    }
}
