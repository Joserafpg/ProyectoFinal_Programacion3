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
    public class UsuarioNegocio
    {     
        private UsuarioDatos datos = new UsuarioDatos();

        public Usuario Login(string nombreUsuario, string clave, out string mensaje)
        {
            mensaje = "";

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(clave))
            {
                mensaje = "Debe digitar el usuario y la contraseña.";
                return null;
            }

            Usuario usuario = datos.ObtenerPorNombreUsuario(nombreUsuario.Trim());

            if (usuario == null)
            {
                mensaje = "El usuario no existe.";
                return null;
            }

            if (!usuario.Estado)
            {
                mensaje = "El usuario está inactivo.";
                return null;
            }

            if (usuario.Clave != Seguridad.ObtenerHash(clave))
            {
                mensaje = "Contraseña incorrecta.";
                return null;
            }

            usuario.Clave = "";
            usuario.Permisos = datos.ObtenerPermisos(usuario.IdRol);
            return usuario;
        }

        public List<Usuario> Listar()
        {
            return datos.Listar();
        }

        public string Insertar(Usuario usuario, string clave)
        {
            string error = Validar(usuario);
            if (error != "")
                return error;

            if (string.IsNullOrWhiteSpace(clave) || clave.Length < 6)
                return "La contraseña debe tener al menos 6 caracteres.";

            usuario.Clave = Seguridad.ObtenerHash(clave);

            try
            {
                datos.Insertar(usuario);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un usuario con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Usuario usuario)
        {
            string error = Validar(usuario);
            if (error != "")
                return error;

            try
            {
                datos.Actualizar(usuario);
                return "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un usuario con ese nombre.";
                return "Error al guardar: " + ex.Message;
            }
        }

        public string CambiarClave(int idUsuario, string claveNueva)
        {
            if (string.IsNullOrWhiteSpace(claveNueva) || claveNueva.Length < 6)
                return "La contraseña debe tener al menos 6 caracteres.";

            try
            {
                datos.CambiarClave(idUsuario, Seguridad.ObtenerHash(claveNueva));
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar la contraseña: " + ex.Message;
            }
        }

        public string CambiarEstado(int idUsuario, bool estado)
        {
            try
            {
                datos.CambiarEstado(idUsuario, estado);
                return "";
            }
            catch (SqlException ex)
            {
                return "Error al cambiar el estado: " + ex.Message;
            }
        }

        private string Validar(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
                return "El nombre de usuario es obligatorio.";

            if (string.IsNullOrWhiteSpace(usuario.NombreCompleto))
                return "El nombre completo es obligatorio.";

            if (usuario.IdRol <= 0)
                return "Debe seleccionar un rol.";

            return "";
        }
    }
}
