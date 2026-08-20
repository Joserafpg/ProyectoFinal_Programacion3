namespace CapaEntidades
{
    // un renglon del carrito de pagos: lo que el cliente tiene pendiente y se va a cobrar
    public class PagoPendiente
    {
        public string Tipo { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }

        public Membresia Membresia { get; set; }
        public ClienteMembresia ClienteMembresia { get; set; }
        public CuentaCobrar Cuenta { get; set; }
    }
}
