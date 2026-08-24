using System;

namespace CapaEntidades
{
    // resumen de lo que un cliente le debe al gimnasio
    public class Deudor
    {
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public string Cedula { get; set; }
        public decimal Credito { get; set; }
        public int VisitasPendientes { get; set; }
        public decimal MontoVisitas { get; set; }
        public string UltimoPlan { get; set; }
        public DateTime? UltimoVencimiento { get; set; }

        public string Membresia
        {
            get
            {
                if (UltimoVencimiento == null) return "Sin membresía";
                if (UltimoVencimiento.Value >= DateTime.Today) return "Al día";
                return UltimoPlan + " · venció el " + UltimoVencimiento.Value.ToString("dd/MM/yyyy") + " (hace " + (DateTime.Today - UltimoVencimiento.Value).Days + " días)";
            }
        }

        // dinero que ya consumio y no ha pagado (la renovacion no se cuenta hasta que la compre)
        public decimal Total
        {
            get { return Credito + MontoVisitas; }
        }
    }
}
