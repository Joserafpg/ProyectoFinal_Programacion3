using System;

namespace CapaEntidades
{
    public class Pago
    {
        public int IdPago { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public string Concepto { get; set; }
        public string MetodoPago { get; set; }
        public decimal MontoTotal { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
    }
}
