using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CuentaCobrarNegocio
    {
        private CuentaCobrarDatos datos = new CuentaCobrarDatos();

        public List<CuentaCobrar> ListarPendientes()
        {
            return datos.ListarPendientes();
        }

        public List<CuentaCobrar> ListarPorCliente(int idCliente)
        {
            return datos.ListarPorCliente(idCliente);
        }

        public decimal ObtenerDeuda(int idCliente)
        {
            return datos.ObtenerDeuda(idCliente);
        }

        public string Abonar(CuentaCobrar cuenta, decimal monto, string metodoPago, int idUsuario)
        {
            if (cuenta == null)
                return "Debe seleccionar la cuenta a la que va a abonar.";

            if (monto <= 0)
                return "El monto del abono debe ser mayor que cero.";

            if (monto > cuenta.Saldo)
                return "El abono no puede ser mayor que el saldo pendiente (RD$" + cuenta.Saldo.ToString("N2") + ").";

            if (string.IsNullOrWhiteSpace(metodoPago))
                return "Debe seleccionar el método de pago.";

            if (idUsuario <= 0)
                return "No se pudo identificar el usuario que cobra.";

            var pago = new Pago
            {
                IdCliente = cuenta.IdCliente,
                IdUsuario = idUsuario,
                MetodoPago = metodoPago,
                MontoTotal = monto
            };

            try
            {
                datos.Abonar(pago, cuenta.IdCuenta, "Abono a crédito · Venta #" + cuenta.IdVenta);
                return "";
            }
            catch (Exception ex)
            {
                return "Error al registrar el abono: " + ex.Message;
            }
        }
    }
}
