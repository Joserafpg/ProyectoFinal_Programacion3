using System;

namespace CapaEntidades
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public byte[] Foto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }

        // fecha_fin de su ultima membresia, null si nunca ha tenido
        public DateTime? UltimoVencimiento { get; set; }

        public string EstadoMembresia
        {
            get
            {
                if (UltimoVencimiento == null) return "Sin membresía";
                return UltimoVencimiento.Value >= DateTime.Today ? "Al día" : "Vencida";
            }
        }
    }
}
