using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CapaEntidades;

namespace CapaNegocio
{
    public class CorreoBienvenidaNegocio
    {
        private const string ResendUrl = "https://api.resend.com/emails";
        public const string CorreoNoConfigurado = "CORREO_NO_CONFIGURADO";

        public static bool FueOmitido(string resultado)
        {
            return resultado == CorreoNoConfigurado;
        }

        public async Task<string> EnviarAsync(Cliente cliente)
        {
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.Correo))
                return "El cliente no tiene un correo electrónico.";

            Configuracion configuracion = null;
            try { configuracion = new ConfiguracionNegocio().Obtener(); }
            catch { /* El correo puede usar valores predeterminados. */ }

            string gimnasio = configuracion != null && !string.IsNullOrWhiteSpace(configuracion.NombreGimnasio)
                ? configuracion.NombreGimnasio.Trim() : "nuestro gimnasio";

            return await EnviarCorreoAsync(
                cliente.Correo,
                "¡Bienvenido a " + gimnasio + "!",
                CrearHtml((cliente.Nombre + " " + cliente.Apellido).Trim(), gimnasio, configuracion),
                gimnasio);
        }

        public async Task<string> EnviarRecordatorioAsync(Cliente cliente, Deudor deuda)
        {
            if (cliente == null || deuda == null)
                return "Debe seleccionar un cliente.";
            if (string.IsNullOrWhiteSpace(cliente.Correo))
                return "El cliente no tiene un correo electrónico registrado.";

            Configuracion configuracion = null;
            try { configuracion = new ConfiguracionNegocio().Obtener(); }
            catch { /* El correo puede usar valores predeterminados. */ }

            string gimnasio = configuracion != null && !string.IsNullOrWhiteSpace(configuracion.NombreGimnasio)
                ? configuracion.NombreGimnasio.Trim() : "nuestro gimnasio";

            return await EnviarCorreoAsync(
                cliente.Correo,
                "Recordatorio de pago · " + gimnasio,
                CrearHtmlRecordatorio(cliente.NombreCompleto, gimnasio, configuracion, deuda),
                gimnasio);
        }

        public async Task<string> EnviarFacturaAsync(Cliente cliente, Venta venta)
        {
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.Correo))
                return "El cliente no tiene un correo electrónico registrado.";
            if (venta == null || venta.Detalles == null)
                return "No se encontró la información de la factura.";

            Configuracion configuracion = null;
            try { configuracion = new ConfiguracionNegocio().Obtener(); }
            catch { /* El correo puede usar valores predeterminados. */ }
            string gimnasio = configuracion != null && !string.IsNullOrWhiteSpace(configuracion.NombreGimnasio)
                ? configuracion.NombreGimnasio.Trim() : "nuestro gimnasio";

            return await EnviarCorreoAsync(cliente.Correo, "Factura No. " + venta.NumeroFactura + " · " + gimnasio,
                CrearHtmlFactura(cliente.NombreCompleto, gimnasio, venta), gimnasio);
        }

        public async Task<string> EnviarReciboPagoAsync(Cliente cliente, IList<PagoPendiente> items, string metodoPago)
        {
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.Correo))
                return "El cliente no tiene un correo electrónico registrado.";
            if (items == null || items.Count == 0)
                return "No se encontró el detalle del pago.";

            Configuracion configuracion = null;
            try { configuracion = new ConfiguracionNegocio().Obtener(); }
            catch { /* El correo puede usar valores predeterminados. */ }
            string gimnasio = configuracion != null && !string.IsNullOrWhiteSpace(configuracion.NombreGimnasio)
                ? configuracion.NombreGimnasio.Trim() : "nuestro gimnasio";

            return await EnviarCorreoAsync(cliente.Correo, "Recibo de pago · " + gimnasio,
                CrearHtmlReciboPago(cliente.NombreCompleto, gimnasio, items, metodoPago), gimnasio);
        }

        private static async Task<string> EnviarCorreoAsync(string destino, string asunto, string html, string gimnasio)
        {
            string apiKey = Environment.GetEnvironmentVariable("RESEND_API_KEY");
            if (string.IsNullOrWhiteSpace(apiKey))
                return CorreoNoConfigurado;

            string remitente = Environment.GetEnvironmentVariable("RESEND_FROM");
            if (string.IsNullOrWhiteSpace(remitente))
                remitente = gimnasio + " <onboarding@resend.dev>";

            var payload = new Dictionary<string, object>
            {
                { "from", remitente },
                { "to", new[] { destino.Trim() } },
                { "subject", asunto },
                { "html", html }
            };

            try
            {
                using (var http = new HttpClient())
                {
                    http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey.Trim());
                    string json = new JavaScriptSerializer().Serialize(payload);
                    using (var contenido = new StringContent(json, Encoding.UTF8, "application/json"))
                    using (HttpResponseMessage respuesta = await http.PostAsync(ResendUrl, contenido))
                    {
                        if (respuesta.IsSuccessStatusCode) return "";
                        string detalle = await respuesta.Content.ReadAsStringAsync();
                        return "Resend rechazó el correo (" + (int)respuesta.StatusCode + "): " + detalle;
                    }
                }
            }
            catch (Exception ex)
            {
                return "No se pudo conectar con Resend: " + ex.Message;
            }
        }

        private static string CrearHtml(string nombre, string gimnasio, Configuracion configuracion)
        {
            Func<string, string> escapar = valor => System.Net.WebUtility.HtmlEncode(valor ?? "");
            string contacto = "";
            if (configuracion != null && !string.IsNullOrWhiteSpace(configuracion.Telefono))
                contacto = "<p style=\"margin:8px 0;color:#555\">Teléfono: " + escapar(configuracion.Telefono) + "</p>";
            if (configuracion != null && !string.IsNullOrWhiteSpace(configuracion.Direccion))
                contacto += "<p style=\"margin:8px 0;color:#555\">Dirección: " + escapar(configuracion.Direccion) + "</p>";

            return "<!doctype html><html><body style=\"margin:0;background:#f4f5f7;font-family:Arial,sans-serif\">" +
                "<div style=\"max-width:600px;margin:30px auto;background:white;border-radius:12px;overflow:hidden\">" +
                "<div style=\"background:#20243a;color:white;padding:28px;text-align:center\"><h1 style=\"margin:0\">" + escapar(gimnasio) + "</h1></div>" +
                "<div style=\"padding:32px;color:#292d3e\"><h2>¡Bienvenido, " + escapar(nombre) + "!</h2>" +
                "<p style=\"font-size:16px;line-height:1.6\">Tu registro fue completado correctamente. Ya eres parte de nuestra comunidad y nos alegra acompañarte en tus metas.</p>" +
                contacto + "<p style=\"margin-top:28px;font-size:14px;color:#777\">Este mensaje fue generado automáticamente al registrar tu cuenta.</p>" +
                "</div></div></body></html>";
        }

        private static string CrearHtmlRecordatorio(string nombre, string gimnasio, Configuracion configuracion, Deudor deuda)
        {
            Func<string, string> escapar = valor => System.Net.WebUtility.HtmlEncode(valor ?? "");
            string detalle = "";

            if (deuda.Credito > 0)
                detalle += "<tr><td style=\"padding:8px;border-bottom:1px solid #eee\">Crédito pendiente</td><td style=\"padding:8px;text-align:right;border-bottom:1px solid #eee\">RD$" + deuda.Credito.ToString("N2") + "</td></tr>";
            if (deuda.MontoVisitas > 0)
                detalle += "<tr><td style=\"padding:8px;border-bottom:1px solid #eee\">" + deuda.VisitasPendientes + " visita(s) pendiente(s)</td><td style=\"padding:8px;text-align:right;border-bottom:1px solid #eee\">RD$" + deuda.MontoVisitas.ToString("N2") + "</td></tr>";
            if (deuda.Total > 0)
                detalle += "<tr><td style=\"padding:10px;font-weight:bold\">Total pendiente</td><td style=\"padding:10px;text-align:right;font-weight:bold\">RD$" + deuda.Total.ToString("N2") + "</td></tr>";
            if (deuda.UltimoVencimiento != null && deuda.UltimoVencimiento.Value < DateTime.Today)
                detalle += "<tr><td colspan=\"2\" style=\"padding:10px;color:#b42318\">Membresía: " + escapar(deuda.Membresia) + "</td></tr>";

            string contacto = "";
            if (configuracion != null && !string.IsNullOrWhiteSpace(configuracion.Telefono))
                contacto = "<p style=\"color:#555\">Puedes comunicarte con nosotros al " + escapar(configuracion.Telefono) + ".</p>";

            return "<!doctype html><html><body style=\"margin:0;background:#f4f5f7;font-family:Arial,sans-serif\">" +
                "<div style=\"max-width:600px;margin:30px auto;background:white;border-radius:12px;overflow:hidden\">" +
                "<div style=\"background:#20243a;color:white;padding:28px;text-align:center\"><h1 style=\"margin:0\">" + escapar(gimnasio) + "</h1></div>" +
                "<div style=\"padding:32px;color:#292d3e\"><h2>Hola, " + escapar(nombre) + "</h2>" +
                "<p style=\"font-size:16px;line-height:1.6\">Este es un recordatorio amable sobre tu cuenta con nosotros.</p>" +
                "<table style=\"width:100%;border-collapse:collapse;margin:20px 0\">" + detalle + "</table>" + contacto +
                "<p style=\"font-size:14px;color:#777\">Si ya realizaste el pago, puedes ignorar este mensaje.</p>" +
                "</div></div></body></html>";
        }

        private static string CrearHtmlFactura(string nombre, string gimnasio, Venta venta)
        {
            Func<string, string> escapar = valor => System.Net.WebUtility.HtmlEncode(valor ?? "");
            string filas = "";
            foreach (VentaDetalle item in venta.Detalles)
            {
                filas += "<tr><td style=\"padding:8px;border-bottom:1px solid #eee\">" + escapar(item.Producto) + "</td>" +
                    "<td style=\"padding:8px;text-align:center;border-bottom:1px solid #eee\">" + item.Cantidad + "</td>" +
                    "<td style=\"padding:8px;text-align:right;border-bottom:1px solid #eee\">RD$" + item.Subtotal.ToString("N2") + "</td></tr>";
            }

            return "<!doctype html><html><body style=\"margin:0;background:#f4f5f7;font-family:Arial,sans-serif\">" +
                "<div style=\"max-width:650px;margin:30px auto;background:white;border-radius:12px;overflow:hidden\">" +
                "<div style=\"background:#20243a;color:white;padding:28px;text-align:center\"><h1 style=\"margin:0\">" + escapar(gimnasio) + "</h1></div>" +
                "<div style=\"padding:32px;color:#292d3e\"><h2>Factura No. " + venta.NumeroFactura + "</h2>" +
                "<p>Hola, " + escapar(nombre) + ". Gracias por tu compra.</p><p>Fecha: " + venta.Fecha.ToString("dd/MM/yyyy hh:mm tt") + "</p>" +
                "<table style=\"width:100%;border-collapse:collapse;margin:20px 0\"><tr style=\"background:#fde68a\"><th style=\"padding:8px;text-align:left\">Producto</th><th>Cant.</th><th style=\"text-align:right;padding:8px\">Importe</th></tr>" + filas + "</table>" +
                "<p style=\"text-align:right\">Subtotal: RD$" + venta.Subtotal.ToString("N2") + "</p>" +
                "<p style=\"text-align:right\">Impuesto: RD$" + venta.Impuesto.ToString("N2") + "</p>" +
                "<h3 style=\"text-align:right\">Total: RD$" + venta.Total.ToString("N2") + "</h3>" +
                "<p style=\"font-size:14px;color:#777\">Forma de pago: " + escapar(venta.TipoPago) + "</p></div></div></body></html>";
        }

        private static string CrearHtmlReciboPago(string nombre, string gimnasio, IList<PagoPendiente> items, string metodoPago)
        {
            Func<string, string> escapar = valor => System.Net.WebUtility.HtmlEncode(valor ?? "");
            string filas = "";
            decimal total = 0;
            foreach (PagoPendiente item in items)
            {
                total += item.Monto;
                filas += "<tr><td style=\"padding:9px;border-bottom:1px solid #eee\">" + escapar(item.Concepto) + "</td>" +
                    "<td style=\"padding:9px;text-align:right;border-bottom:1px solid #eee\">RD$" + item.Monto.ToString("N2") + "</td></tr>";
            }

            return "<!doctype html><html><body style=\"margin:0;background:#f4f5f7;font-family:Arial,sans-serif\">" +
                "<div style=\"max-width:620px;margin:30px auto;background:white;border-radius:12px;overflow:hidden\">" +
                "<div style=\"background:#20243a;color:white;padding:28px;text-align:center\"><h1 style=\"margin:0\">" + escapar(gimnasio) + "</h1></div>" +
                "<div style=\"padding:32px;color:#292d3e\"><h2>Pago recibido</h2><p>Hola, " + escapar(nombre) + ". Tu pago fue registrado correctamente.</p>" +
                "<p>Fecha: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + "</p>" +
                "<table style=\"width:100%;border-collapse:collapse;margin:20px 0\">" + filas + "</table>" +
                "<h3 style=\"text-align:right\">Total pagado: RD$" + total.ToString("N2") + "</h3>" +
                "<p style=\"color:#555\">Método de pago: " + escapar(metodoPago) + "</p>" +
                "<p style=\"font-size:14px;color:#777\">Conserva este correo como comprobante de tu pago.</p></div></div></body></html>";
        }
    }
}
