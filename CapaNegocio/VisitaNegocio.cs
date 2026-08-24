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
    public class VisitaNegocio
    {
        private VisitaDatos datos = new VisitaDatos();

        // cliente sin membresia: se le carga la visita del dia a su cuenta y entra
        public string Cargar(int idCliente)
        {
            if (idCliente <= 0)
                return "Cliente no válido.";

            if (new ClienteMembresiaDatos().ObtenerActiva(idCliente) != null)
                return "El cliente tiene membresía activa; registre la entrada normal.";

            if (new AsistenciaDatos().YaEntroHoy(idCliente))
                return "Este cliente ya registró su entrada hoy.";

            decimal monto = new ConfiguracionDatos().ObtenerMontoVisita();

            if (monto <= 0)
                return "El monto de la visita del día no está configurado.";

            try
            {
                datos.RegistrarConEntrada(idCliente, monto);
                return "";
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                return "Ya se cargó la visita de hoy a este cliente.";
            }
            catch (Exception ex)
            {
                return "Error al cargar la visita: " + ex.Message;
            }
        }

        public List<Visita> ListarPendientes(int idCliente)
        {
            return datos.ListarPendientes(idCliente);
        }

        public decimal ObtenerDeuda(int idCliente)
        {
            return datos.ListarPendientes(idCliente).Sum(v => v.Monto);
        }
    }
}
