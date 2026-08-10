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
    public class RolNegocio
    {
        private RolDatos datos = new RolDatos();

        public List<Rol> Listar()
        {
            return datos.Listar();
        }

        public string Insertar(Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.Nombre))
                return "El nombre del rol es obligatorio.";

            try
            {
                datos.Insertar(rol);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un rol con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.Nombre))
                return "El nombre del rol es obligatorio.";

            try
            {
                datos.Actualizar(rol);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un rol con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarEstado(int idRol, bool estado)
        {
            try
            {
                datos.CambiarEstado(idRol, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }
    }
}
