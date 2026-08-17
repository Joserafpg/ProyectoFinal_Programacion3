using System;

namespace CapaEntidades
{
    public class CuentaCobrar
    {
        public int IdCuenta { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public string Cedula { get; set; }
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal MontoOriginal { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }

        public string Descripcion
        {
            get { return "Venta #" + IdVenta + " del " + FechaVenta.ToString("dd/MM/yyyy") + " · saldo RD$" + Saldo.ToString("N2"); }
        }
    }
}
