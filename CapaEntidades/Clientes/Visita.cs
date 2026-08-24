using System;

namespace CapaEntidades
{
    // visita del dia de un cliente sin membresia; queda pendiente hasta que se cobra en pagos
    public class Visita
    {
        public int IdVisita { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
        public int? IdPago { get; set; }
    }
}
