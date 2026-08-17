using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ConfiguracionNegocio
    {
        private ConfiguracionDatos datos = new ConfiguracionDatos();

        public Configuracion Obtener()
        {
            return datos.Obtener();
        }

        public string Actualizar(Configuracion configuracion)
        {
            if (string.IsNullOrWhiteSpace(configuracion.NombreGimnasio))
                return "El nombre del gimnasio es obligatorio.";

            if (configuracion.PorcentajeImpuesto < 0 || configuracion.PorcentajeImpuesto > 100)
                return "El porcentaje de impuesto debe estar entre 0 y 100.";

            if (configuracion.MontoVisita < 0)
                return "El monto de la visita no puede ser negativo.";

            try
            {
                datos.Actualizar(configuracion);
                return "";
            }
            catch (Exception ex)
            {
                return "Error al guardar la configuración: " + ex.Message;
            }
        }
    }
}
