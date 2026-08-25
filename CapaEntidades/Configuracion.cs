using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Configuracion
    {
        public int IdConfiguracion { get; set; }
        public string NombreGimnasio { get; set; }
        public string Rnc { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public decimal MontoVisita { get; set; }
        public string MensajeRecibo { get; set; }

        // imagen del logo (png/jpg), null si no se ha cargado
        public byte[] Logo { get; set; }
    }
}
