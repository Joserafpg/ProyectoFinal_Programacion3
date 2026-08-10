using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
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
    }
}
