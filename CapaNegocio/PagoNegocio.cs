using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PagoNegocio
    {
        public List<Pago> Listar()
        {
            return new PagoDatos().Listar();
        }

        public List<Pago> ListarPorCliente(int idCliente)
        {
            return new PagoDatos().ListarPorCliente(idCliente);
        }

        public decimal ObtenerMontoVisita()
        {
            try
            {
                return new ConfiguracionDatos().ObtenerMontoVisita();
            }
            catch
            {
                return 0;
            }
        }

        public string CobrarVisita(string metodoPago, int idUsuario)
        {
            if (string.IsNullOrWhiteSpace(metodoPago))
                return "Debe seleccionar el método de pago.";

            if (idUsuario <= 0)
                return "No se pudo identificar el usuario que cobra.";

            var visitante = new ClienteDatos().ObtenerPorCedula("000-0000000-0");

            if (visitante == null)
                return "No existe el cliente Visitante en la base de datos.";

            var pago = new Pago
            {
                IdCliente = visitante.IdCliente,
                IdUsuario = idUsuario,
                MetodoPago = metodoPago,
                MontoTotal = ObtenerMontoVisita()
            };

            try
            {
                new PagoDatos().RegistrarConDetalle(pago, "Visita del día");
                new AsistenciaDatos().Registrar(visitante.IdCliente);
                return "";
            }
            catch (Exception ex)
            {
                return "Error al cobrar la visita: " + ex.Message;
            }
        }
    }
}
