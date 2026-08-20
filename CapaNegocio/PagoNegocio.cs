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

        // todo lo que el cliente tiene pendiente de pagar: renovar membresia, creditos y la visita
        public List<PagoPendiente> ListarPendientes(Cliente cliente)
        {
            var lista = new List<PagoPendiente>();

            if (cliente == null)
                return lista;

            var planes = new MembresiaDatos().Listar().Where(m => m.Estado).ToList();
            var activa = new ClienteMembresiaDatos().ObtenerActiva(cliente.IdCliente);
            var ultima = new ClienteMembresiaDatos().ObtenerUltima(cliente.IdCliente);

            foreach (var plan in planes)
            {
                string concepto = "Membresía " + plan.Nombre + " (" + plan.DuracionDias + " días)";

                if (activa != null && activa.IdMembresia == plan.IdMembresia)
                    concepto = "Renovar " + plan.Nombre + " (desde el " + activa.FechaFin.AddDays(1).ToString("dd/MM/yyyy") + ")";
                else if (activa == null && ultima != null && ultima.IdMembresia == plan.IdMembresia)
                    concepto = "Renovar " + plan.Nombre + " (vencida el " + ultima.FechaFin.ToString("dd/MM/yyyy") + ")";

                lista.Add(new PagoPendiente { Tipo = "Membresía", Concepto = concepto, Monto = plan.Precio, Membresia = plan });
            }

            foreach (var cuenta in new CuentaCobrarDatos().ListarPorCliente(cliente.IdCliente))
            {
                lista.Add(new PagoPendiente { Tipo = "Crédito", Concepto = "Abono a crédito · " + cuenta.Descripcion, Monto = cuenta.Saldo, Cuenta = cuenta });
            }

            if (activa == null)
            {
                lista.Add(new PagoPendiente { Tipo = "Visita", Concepto = "Visita del día", Monto = ObtenerMontoVisita() });
            }

            return lista;
        }

        public string CobrarPendientes(Cliente cliente, List<PagoPendiente> items, string metodoPago, int idUsuario)
        {
            if (cliente == null)
                return "Debe seleccionar un cliente.";

            if (items == null || items.Count == 0)
                return "Debe agregar al menos un pago.";

            if (string.IsNullOrWhiteSpace(metodoPago))
                return "Debe seleccionar el método de pago.";

            if (idUsuario <= 0)
                return "No se pudo identificar el usuario que cobra.";

            if (items.Count(i => i.Membresia != null) > 1)
                return "Solo puede cobrar una membresía por pago.";

            foreach (var item in items)
            {
                if (item.Monto <= 0)
                    return "El monto de \"" + item.Concepto + "\" debe ser mayor que cero.";

                if (item.Cuenta != null && item.Monto > item.Cuenta.Saldo)
                    return "El abono a la venta #" + item.Cuenta.IdVenta + " no puede ser mayor que su saldo (RD$" + item.Cuenta.Saldo.ToString("N2") + ").";
            }

            // la membresia arranca hoy, o cuando venza la actual si tiene una activa
            var itemMembresia = items.Find(i => i.Membresia != null);

            if (itemMembresia != null)
            {
                DateTime inicio = DateTime.Today;
                var activa = new ClienteMembresiaDatos().ObtenerActiva(cliente.IdCliente);

                if (activa != null)
                    inicio = activa.FechaFin.AddDays(1);

                itemMembresia.ClienteMembresia = new ClienteMembresia
                {
                    IdCliente = cliente.IdCliente,
                    IdMembresia = itemMembresia.Membresia.IdMembresia,
                    FechaInicio = inicio,
                    FechaFin = inicio.AddDays(itemMembresia.Membresia.DuracionDias - 1)
                };
            }

            var pago = new Pago
            {
                IdCliente = cliente.IdCliente,
                IdUsuario = idUsuario,
                MetodoPago = metodoPago,
                MontoTotal = items.Sum(i => i.Monto)
            };

            try
            {
                new PagoDatos().RegistrarCombinado(pago, items);
                return "";
            }
            catch (Exception ex)
            {
                return "Error al registrar el pago: " + ex.Message;
            }
        }

        public string CobrarVisita(string metodoPago, int idUsuario, Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(metodoPago))
                return "Debe seleccionar el método de pago.";

            if (idUsuario <= 0)
                return "No se pudo identificar el usuario que cobra.";

            var visitante = cliente;

            if (visitante == null)
                visitante = new ClienteDatos().ObtenerPorCedula("000-0000000-0");

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
