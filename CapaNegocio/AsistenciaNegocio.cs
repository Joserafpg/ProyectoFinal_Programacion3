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

            if (new ClienteMembresiaDatos().ObtenerActiva(idCliente) == null)
                return "El cliente no tiene una membresía activa. Debe renovar o pagar la visita del día.";

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

        public bool YaEntroHoy(int idCliente)
        {
            return datos.YaEntroHoy(idCliente);
        }

        public List<Asistencia> ListarHoy()
        {
            return datos.ListarHoy();
        }
    }
}
