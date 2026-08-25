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

        public async Task<string> EnviarAsync(Cliente cliente)
        {
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.Correo))
                return "El cliente no tiene un correo electrónico.";

            string apiKey = Environment.GetEnvironmentVariable("RESEND_API_KEY");
            if (string.IsNullOrWhiteSpace(apiKey))
                return "No se configuró la variable de entorno RESEND_API_KEY.";

            Configuracion configuracion = null;
            try { configuracion = new ConfiguracionNegocio().Obtener(); }
            catch { /* El correo puede usar valores predeterminados. */ }

            string gimnasio = configuracion != null && !string.IsNullOrWhiteSpace(configuracion.NombreGimnasio)
                ? configuracion.NombreGimnasio.Trim() : "nuestro gimnasio";
            string remitente = Environment.GetEnvironmentVariable("RESEND_FROM");
            if (string.IsNullOrWhiteSpace(remitente))
                remitente = gimnasio + " <onboarding@resend.dev>";

            var payload = new Dictionary<string, object>
            {
                { "from", remitente },
                { "to", new[] { cliente.Correo.Trim() } },
                { "subject", "¡Bienvenido a " + gimnasio + "!" },
                { "html", CrearHtml((cliente.Nombre + " " + cliente.Apellido).Trim(), gimnasio, configuracion) }
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
    }
}
