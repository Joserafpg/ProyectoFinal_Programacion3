namespace CapaEntidades
{
    // un renglon de lo que se cobro en un pago (membresia, abono, visita)
    public class PagoDetalle
    {
        public int IdPago { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
    }
}
