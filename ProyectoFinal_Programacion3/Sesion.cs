using System.Drawing;
using System.IO;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public static class Sesion
    {
        public static Usuario UsuarioActual = null;

        // true si el rol del usuario conectado tiene el permiso (nombres de la tabla permisos: POS, PAGOS, CLIENTES...)
        public static bool Tiene(string permiso)
        {
            return UsuarioActual != null && UsuarioActual.Permisos != null && UsuarioActual.Permisos.Contains(permiso);
        }

        // datos del gimnasio (nombre, logo, impuesto...) que se muestran en toda la aplicacion.
        // se cargan al abrir el login y se refrescan al guardar en Configuracion
        public static Configuracion Negocio = null;

        public static void CargarNegocio()
        {
            try
            {
                Negocio = new ConfiguracionNegocio().Obtener();
            }
            catch
            {
                // sin conexion se sigue con los datos por defecto; el login ya avisa cuando falla la base de datos
                Negocio = null;
            }
        }

        public static string NombreNegocio
        {
            get
            {
                return Negocio == null || string.IsNullOrWhiteSpace(Negocio.NombreGimnasio) ? "SmartFit Software" : Negocio.NombreGimnasio;
            }
        }

        // el logo configurado, o la imagen por defecto si no hay
        public static Image LogoNegocio(Image porDefecto)
        {
            return Negocio == null ? porDefecto : ImagenDesdeBytes(Negocio.Logo, porDefecto);
        }

        // copia independiente de la imagen, para no depender del stream ni de la base de datos
        public static Image ImagenDesdeBytes(byte[] bytes, Image porDefecto)
        {
            if (bytes == null || bytes.Length == 0) return porDefecto;

            try
            {
                using (var stream = new MemoryStream(bytes))
                using (var imagen = Image.FromStream(stream))
                {
                    return new Bitmap(imagen);
                }
            }
            catch
            {
                return porDefecto;
            }
        }
    }
}
