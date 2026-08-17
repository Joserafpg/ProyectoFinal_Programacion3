using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class AsistenciaNegocio
    {
        private AsistenciaDatos datos = new AsistenciaDatos();

        public string RegistrarEntrada(int idCliente)
        {
            if (idCliente <= 0)
                return "Cliente no válido.";

            if (datos.YaEntroHoy(idCliente))
                return "Este cliente ya registró su entrada hoy.";

            try
            {
                datos.Registrar(idCliente);
                return "";
            }
            catch (Exception ex)
            {
                return "Error al registrar la entrada: " + ex.Message;
            }
        }

        public List<Asistencia> ListarHoy()
        {
            return datos.ListarHoy();
        }
    }
}
