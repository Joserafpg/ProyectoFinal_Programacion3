using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClienteMembresiaNegocio
    {
        private ClienteMembresiaDatos datos = new ClienteMembresiaDatos();

        public string Asignar(Cliente cliente, Membresia membresia, string metodoPago, int idUsuario)
        {
            if (cliente == null)
                return "Debe seleccionar un cliente.";

            if (membresia == null)
                return "Debe seleccionar una membresía.";

            if (string.IsNullOrWhiteSpace(metodoPago))
                return "Debe seleccionar el método de pago.";

            if (idUsuario <= 0)
                return "No se pudo identificar el usuario que cobra.";

            DateTime fechaInicio = DateTime.Today;

            var activa = datos.ObtenerActiva(cliente.IdCliente);
            if (activa != null)
                fechaInicio = activa.FechaFin.AddDays(1);

            var clienteMembresia = new ClienteMembresia
            {
                IdCliente = cliente.IdCliente,
                IdMembresia = membresia.IdMembresia,
                FechaInicio = fechaInicio,
                FechaFin = fechaInicio.AddDays(membresia.DuracionDias - 1)
            };

            var pago = new Pago
            {
                IdCliente = cliente.IdCliente,
                IdUsuario = idUsuario,
                MetodoPago = metodoPago,
                MontoTotal = membresia.Precio
            };

            try
            {
                datos.Asignar(pago, clienteMembresia, "Membresía " + membresia.Nombre + " (" + membresia.DuracionDias + " días)");
                return "";
            }
            catch (Exception ex)
            {
                return "Error al registrar el pago: " + ex.Message;
            }
        }

        public ClienteMembresia ObtenerActiva(int idCliente)
        {
            return datos.ObtenerActiva(idCliente);
        }

        public ClienteMembresia ObtenerUltima(int idCliente)
        {
            return datos.ObtenerUltima(idCliente);
        }

        public List<ClienteMembresia> ListarVencidas()
        {
            return datos.ListarVencidas();
        }

        public List<ClienteMembresia> ListarPorVencer(int dias)
        {
            return datos.ListarPorVencer(dias);
        }

        public int ContarActivas()
        {
            return datos.ContarActivas();
        }
    }
}
