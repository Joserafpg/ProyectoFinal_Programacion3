using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace ProyectoFinal_Programacion3
{
    // arma la factura de una venta como un PrintDocument (hoja carta) para verla en pantalla,
    // mandarla a la impresora o guardarla en PDF. si el detalle no cabe en una hoja sigue en la siguiente
    public class Factura
    {
        readonly Venta venta;
        readonly Configuracion negocio;
        readonly List<VentaDetalle> detalles;

        static readonly Font fuenteTitulo = new Font("Segoe UI", 20F, FontStyle.Bold);
        static readonly Font fuenteNegocio = new Font("Segoe UI", 15F, FontStyle.Bold);
        static readonly Font fuenteNormal = new Font("Segoe UI", 10F);
        static readonly Font fuenteNegrita = new Font("Segoe UI", 10F, FontStyle.Bold);
        static readonly Font fuentePequena = new Font("Segoe UI", 8.5F);
        static readonly Font fuenteCursiva = new Font("Segoe UI", 10F, FontStyle.Italic);
        static readonly Font fuenteTotal = new Font("Segoe UI", 13F, FontStyle.Bold);
        static readonly Font fuenteAnulada = new Font("Segoe UI", 64F, FontStyle.Bold);

        static readonly Brush brochaTexto = new SolidBrush(Color.FromArgb(33, 37, 65));
        static readonly Brush brochaSecundaria = new SolidBrush(Color.FromArgb(95, 99, 120));
        static readonly Brush brochaEncabezado = new SolidBrush(Color.FromArgb(253, 230, 138));
        static readonly Brush brochaAnulada = new SolidBrush(Color.FromArgb(70, 220, 53, 69));
        static readonly Pen lapizLinea = new Pen(Color.FromArgb(210, 213, 222), 1F);
        static readonly Pen lapizFuerte = new Pen(Color.FromArgb(33, 37, 65), 1.5F);

        static readonly StringFormat derecha = new StringFormat { Alignment = StringAlignment.Far };
        static readonly StringFormat centro = new StringFormat { Alignment = StringAlignment.Center };
        static readonly StringFormat centrado = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

        // medidas en centesimas de pulgada (la unidad de PrintDocument)
        const float AltoPie = 60;
        const float AnchoCantidad = 70;
        const float AnchoPrecio = 120;
        const float AnchoImporte = 130;
        const float Relleno = 6;

        // posicion de las columnas, se calcula con el area imprimible de cada pagina
        RectangleF area;
        float xCantidad, xPrecio, xImporte, anchoDescripcion;

        // por donde va la impresion cuando el detalle ocupa varias paginas
        int indiceDetalle;
        int numeroPagina;

        public Factura(Venta venta, Configuracion negocio)
        {
            this.venta = venta;
            this.negocio = negocio ?? new Configuracion { NombreGimnasio = "Gimnasio" };
            detalles = venta.Detalles ?? new List<VentaDetalle>();
        }

        public PrintDocument CrearDocumento()
        {
            var documento = new PrintDocument();
            documento.DocumentName = "Factura " + venta.NumeroFactura;
            documento.DefaultPageSettings.Margins = new Margins(60, 60, 60, 60);
            documento.BeginPrint += (s, e) => { indiceDetalle = 0; numeroPagina = 0; };
            documento.PrintPage += Documento_PrintPage;
            return documento;
        }

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            numeroPagina++;
            CalcularColumnas(e.MarginBounds);

            float limite = area.Bottom - AltoPie;
            float y = DibujarEncabezado(g, area.Top);

            if (indiceDetalle < detalles.Count)
            {
                y = DibujarEncabezadoTabla(g, y);
            }

            int filasEnPagina = 0;

            while (indiceDetalle < detalles.Count)
            {
                VentaDetalle detalle = detalles[indiceDetalle];
                float alto = AltoFila(g, detalle);

                // si la fila no cabe pasa a la siguiente hoja (salvo que sea la primera de la hoja, para no quedar en bucle)
                if (y + alto > limite && filasEnPagina > 0)
                {
                    DibujarPie(g);
                    e.HasMorePages = true;
                    return;
                }

                DibujarFila(g, y, detalle, alto);
                y += alto;
                indiceDetalle++;
                filasEnPagina++;
            }

            // los totales van completos en una hoja; si no caben, en la siguiente
            if (y + AltoTotales(g) > limite && filasEnPagina > 0)
            {
                DibujarPie(g);
                e.HasMorePages = true;
                return;
            }

            DibujarTotales(g, y);
            DibujarPie(g);
            DibujarAnulada(g);
            e.HasMorePages = false;
        }

        private void CalcularColumnas(Rectangle margenes)
        {
            area = margenes;
            xImporte = area.Right - AnchoImporte;
            xPrecio = xImporte - AnchoPrecio;
            xCantidad = xPrecio - AnchoCantidad;
            anchoDescripcion = xCantidad - area.Left;
        }

        private float DibujarEncabezado(Graphics g, float y)
        {
            float altoNormal = fuenteNormal.GetHeight(g);
            float altoPequena = fuentePequena.GetHeight(g);

            // datos del negocio a la izquierda, con el logo configurado (o el de la aplicacion) en un cuadro de 70x70
            using (Image logo = Sesion.ImagenDesdeBytes(negocio.Logo, new Bitmap(Properties.Resources.icono_logo_login)))
            {
                float escala = Math.Min(70F / logo.Width, 70F / logo.Height);
                float ancho = logo.Width * escala;
                float alto = logo.Height * escala;
                g.DrawImage(logo, area.Left + (70 - ancho) / 2, y + (70 - alto) / 2, ancho, alto);
            }

            float xTexto = area.Left + 84;
            float anchoTexto = xCantidad - xTexto;
            g.DrawString(negocio.NombreGimnasio, fuenteNegocio, brochaTexto, new RectangleF(xTexto, y, anchoTexto, fuenteNegocio.GetHeight(g) + 4));

            float yInfo = y + fuenteNegocio.GetHeight(g) + 4;

            foreach (string linea in LineasNegocio())
            {
                g.DrawString(linea, fuentePequena, brochaSecundaria, xTexto, yInfo);
                yInfo += altoPequena;
            }

            // numero, fecha y forma de pago a la derecha
            float yDerecha = y;
            g.DrawString("FACTURA", fuenteTitulo, brochaTexto, area.Right, yDerecha, derecha);
            yDerecha += fuenteTitulo.GetHeight(g) + 2;
            // antes de confirmar la venta todavia no tiene numero
            g.DrawString("No. " + (venta.IdVenta > 0 ? venta.NumeroFactura : "pendiente"), fuenteNegrita, brochaTexto, area.Right, yDerecha, derecha);
            yDerecha += altoNormal + 2;
            g.DrawString("Fecha: " + venta.Fecha.ToString("dd/MM/yyyy hh:mm tt"), fuenteNormal, brochaTexto, area.Right, yDerecha, derecha);
            yDerecha += altoNormal + 2;
            g.DrawString("Pago: " + (venta.TipoPago == "Credito" ? "Crédito" : "Contado"), fuenteNormal, brochaTexto, area.Right, yDerecha, derecha);
            yDerecha += altoNormal;

            y = Math.Max(Math.Max(yInfo, yDerecha), y + 74) + 10;
            g.DrawLine(lapizFuerte, area.Left, y, area.Right, y);
            y += 12;

            // a quien se le vendio y quien atendio
            float mitad = area.Left + area.Width / 2;
            g.DrawString("Cliente:", fuenteNegrita, brochaSecundaria, area.Left, y);
            g.DrawString(venta.Cliente, fuenteNormal, brochaTexto, new RectangleF(area.Left + 70, y, mitad - area.Left - 80, altoNormal + 4));
            g.DrawString("Vendedor:", fuenteNegrita, brochaSecundaria, mitad, y);
            g.DrawString(venta.Usuario, fuenteNormal, brochaTexto, new RectangleF(mitad + 85, y, area.Right - mitad - 85, altoNormal + 4));
            y += altoNormal + 4;

            if (!string.IsNullOrWhiteSpace(venta.CedulaCliente))
            {
                g.DrawString("Cédula:", fuenteNegrita, brochaSecundaria, area.Left, y);
                g.DrawString(venta.CedulaCliente, fuenteNormal, brochaTexto, area.Left + 70, y);
                y += altoNormal + 4;
            }

            return y + 12;
        }

        private List<string> LineasNegocio()
        {
            var lineas = new List<string>();

            if (!string.IsNullOrWhiteSpace(negocio.Rnc)) lineas.Add("RNC: " + negocio.Rnc);
            if (!string.IsNullOrWhiteSpace(negocio.Direccion)) lineas.Add(negocio.Direccion);

            string contacto = "";
            if (!string.IsNullOrWhiteSpace(negocio.Telefono)) contacto = "Tel.: " + negocio.Telefono;
            if (!string.IsNullOrWhiteSpace(negocio.Correo)) contacto += (contacto.Length > 0 ? "  ·  " : "") + negocio.Correo;
            if (contacto.Length > 0) lineas.Add(contacto);

            return lineas;
        }

        private float DibujarEncabezadoTabla(Graphics g, float y)
        {
            float alto = fuenteNegrita.GetHeight(g) + 10;
            g.FillRectangle(brochaEncabezado, area.Left, y, area.Width, alto);

            float yTexto = y + 5;
            g.DrawString("Descripción", fuenteNegrita, brochaTexto, area.Left + Relleno, yTexto);
            g.DrawString("Cant.", fuenteNegrita, brochaTexto, new RectangleF(xCantidad, yTexto, AnchoCantidad, alto), derecha);
            g.DrawString("Precio", fuenteNegrita, brochaTexto, new RectangleF(xPrecio, yTexto, AnchoPrecio, alto), derecha);
            g.DrawString("Importe", fuenteNegrita, brochaTexto, new RectangleF(xImporte, yTexto, AnchoImporte - Relleno, alto), derecha);

            return y + alto;
        }

        private float AltoFila(Graphics g, VentaDetalle detalle)
        {
            float altoTexto = g.MeasureString(detalle.Producto, fuenteNormal, (int)(anchoDescripcion - Relleno * 2)).Height;
            return Math.Max(altoTexto, fuenteNormal.GetHeight(g)) + 10;
        }

        private void DibujarFila(Graphics g, float y, VentaDetalle detalle, float alto)
        {
            float yTexto = y + 5;
            g.DrawString(detalle.Producto, fuenteNormal, brochaTexto, new RectangleF(area.Left + Relleno, yTexto, anchoDescripcion - Relleno * 2, alto - 5));
            g.DrawString(detalle.Cantidad.ToString(), fuenteNormal, brochaTexto, new RectangleF(xCantidad, yTexto, AnchoCantidad, alto), derecha);
            g.DrawString(detalle.Precio.ToString("N2"), fuenteNormal, brochaTexto, new RectangleF(xPrecio, yTexto, AnchoPrecio, alto), derecha);
            g.DrawString(detalle.Subtotal.ToString("N2"), fuenteNormal, brochaTexto, new RectangleF(xImporte, yTexto, AnchoImporte - Relleno, alto), derecha);
            g.DrawLine(lapizLinea, area.Left, y + alto, area.Right, y + alto);
        }

        private float AltoTotales(Graphics g)
        {
            return (fuenteNormal.GetHeight(g) + 4) * 4 + fuenteTotal.GetHeight(g) + 40;
        }

        private void DibujarTotales(Graphics g, float y)
        {
            y += 14;
            float altoLinea = fuenteNormal.GetHeight(g) + 4;

            // las etiquetas terminan donde empieza la columna de precio y los montos usan precio + importe,
            // para que el total en letra grande no se recorte
            float xEtiqueta = xCantidad - 40;
            float anchoEtiqueta = xPrecio - xEtiqueta;
            float yDerecha = y;

            yDerecha = LineaTotal(g, yDerecha, "Subtotal", venta.Subtotal, fuenteNormal, xEtiqueta, anchoEtiqueta);

            if (venta.Descuento > 0)
            {
                yDerecha = LineaTotal(g, yDerecha, "Descuento", -venta.Descuento, fuenteNormal, xEtiqueta, anchoEtiqueta);
            }

            yDerecha = LineaTotal(g, yDerecha, "ITBIS (" + PorcentajeImpuesto().ToString("0.##") + "%)", venta.Impuesto, fuenteNormal, xEtiqueta, anchoEtiqueta);

            yDerecha += 4;
            g.DrawLine(lapizFuerte, xEtiqueta, yDerecha, area.Right, yDerecha);
            yDerecha += 6;
            LineaTotal(g, yDerecha, "TOTAL", venta.Total, fuenteTotal, xEtiqueta, anchoEtiqueta);

            // el monto en letras y la nota del credito a la izquierda
            float anchoIzquierda = xEtiqueta - area.Left - 20;
            string enLetras = "Son: " + NumeroALetras.Convertir(venta.Total);
            RectangleF rectLetras = new RectangleF(area.Left, y, anchoIzquierda, altoLinea * 3);
            g.DrawString(enLetras, fuentePequena, brochaSecundaria, rectLetras);

            if (venta.TipoPago == "Credito")
            {
                float yNota = y + g.MeasureString(enLetras, fuentePequena, (int)anchoIzquierda).Height + 6;
                string nota = "Venta a crédito. Vence el " + venta.Fecha.Date.AddDays(VentaNegocio.DiasCredito).ToString("dd/MM/yyyy") + ".";
                g.DrawString(nota, fuenteNegrita, brochaTexto, new RectangleF(area.Left, yNota, anchoIzquierda, altoLinea * 2));
            }
        }

        private float LineaTotal(Graphics g, float y, string etiqueta, decimal monto, Font fuente, float xEtiqueta, float anchoEtiqueta)
        {
            float alto = fuente.GetHeight(g) + 4;
            g.DrawString(etiqueta, fuente, brochaTexto, new RectangleF(xEtiqueta, y, anchoEtiqueta, alto), derecha);
            g.DrawString("RD$" + monto.ToString("N2"), fuente, brochaTexto, new RectangleF(xPrecio, y, area.Right - Relleno - xPrecio, alto), derecha);
            return y + alto;
        }

        // el porcentaje real que se aplico en la venta; si no hubo subtotal se usa el configurado
        private decimal PorcentajeImpuesto()
        {
            if (venta.Subtotal <= 0) return negocio.PorcentajeImpuesto;
            return Math.Round(venta.Impuesto / venta.Subtotal * 100, 2);
        }

        private void DibujarPie(Graphics g)
        {
            float y = area.Bottom - AltoPie;
            g.DrawLine(lapizLinea, area.Left, y, area.Right, y);
            y += 8;

            if (!string.IsNullOrWhiteSpace(negocio.MensajeRecibo))
            {
                g.DrawString(negocio.MensajeRecibo, fuenteCursiva, brochaTexto, new RectangleF(area.Left, y, area.Width, fuenteCursiva.GetHeight(g) + 2), centro);
            }

            y += fuenteCursiva.GetHeight(g) + 6;
            string pie = "Impreso el " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + "  ·  Página " + numeroPagina;
            g.DrawString(pie, fuentePequena, brochaSecundaria, new RectangleF(area.Left, y, area.Width, fuentePequena.GetHeight(g) + 2), centro);
        }

        // marca de agua cruzada cuando la venta fue anulada
        private void DibujarAnulada(Graphics g)
        {
            if (venta.Estado != "Anulada") return;

            var estado = g.Save();
            g.TranslateTransform(area.Left + area.Width / 2, area.Top + area.Height / 2);
            g.RotateTransform(-35);
            g.DrawString("ANULADA", fuenteAnulada, brochaAnulada, 0, 0, centrado);
            g.Restore(estado);
        }
    }

    // convierte un monto a letras al estilo de las facturas: "MIL DOSCIENTOS PESOS CON 50/100"
    public static class NumeroALetras
    {
        static readonly string[] unidades =
        {
            "", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ",
            "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISÉIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE", "VEINTE",
            "VEINTIUNO", "VEINTIDÓS", "VEINTITRÉS", "VEINTICUATRO", "VEINTICINCO", "VEINTISÉIS", "VEINTISIETE", "VEINTIOCHO", "VEINTINUEVE"
        };

        static readonly string[] decenas = { "", "", "", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };

        static readonly string[] centenas =
        {
            "", "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS"
        };

        public static string Convertir(decimal monto)
        {
            long entero = (long)Math.Floor(monto);
            int centavos = (int)Math.Round((monto - entero) * 100);

            if (centavos == 100)
            {
                entero++;
                centavos = 0;
            }

            // "UN PESO", "VEINTIÚN PESOS", "UN MILLÓN DE PESOS"
            string letras = entero == 0 ? "CERO" : Apocope(EnLetras(entero));
            if (entero > 0 && entero % 1000000 == 0) letras += " DE";
            string moneda = entero == 1 ? "PESO" : "PESOS";

            return letras + " " + moneda + " CON " + centavos.ToString("00") + "/100";
        }

        private static string EnLetras(long n)
        {
            if (n < 30) return unidades[n];
            if (n < 100) return decenas[n / 10] + (n % 10 > 0 ? " Y " + unidades[n % 10] : "");
            if (n == 100) return "CIEN";
            if (n < 1000) return centenas[n / 100] + Resto(n % 100);
            if (n < 2000) return "MIL" + Resto(n % 1000);
            if (n < 1000000) return Apocope(EnLetras(n / 1000)) + " MIL" + Resto(n % 1000);
            if (n < 2000000) return "UN MILLÓN" + Resto(n % 1000000);
            return Apocope(EnLetras(n / 1000000)) + " MILLONES" + Resto(n % 1000000);
        }

        private static string Resto(long n)
        {
            return n > 0 ? " " + EnLetras(n) : "";
        }

        // "VEINTIUNO MIL" -> "VEINTIÚN MIL", "TREINTA Y UNO MIL" -> "TREINTA Y UN MIL"
        private static string Apocope(string texto)
        {
            if (texto.EndsWith("VEINTIUNO")) return texto.Substring(0, texto.Length - 9) + "VEINTIÚN";
            if (texto.EndsWith("UNO")) return texto.Substring(0, texto.Length - 1);
            return texto;
        }
    }
}
