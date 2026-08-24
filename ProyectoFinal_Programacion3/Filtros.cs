using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    // helper para las barras de filtros: arma [titulo][control] con el mismo aspecto en todas las pantallas.
    // cada filtro que se agrega queda a la derecha del anterior; si la barra tiene un control Fill, este sigue al final
    public static class Filtros
    {
        static readonly Font fuente = new Font("Segoe UI", 10F);
        static readonly Color colorTexto = Color.FromArgb(71, 75, 100);

        public static ComboBox AgregarCombo(Control barra, string titulo, int ancho, params string[] opciones)
        {
            var combo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Font = fuente, ForeColor = colorTexto, Dock = DockStyle.Top };
            combo.Items.AddRange(opciones);

            if (opciones.Length > 0)
            {
                combo.SelectedIndex = 0;
            }

            Agregar(barra, titulo, ancho, combo);
            return combo;
        }

        public static DateTimePicker AgregarFecha(Control barra, string titulo, DateTime valor)
        {
            var fecha = new DateTimePicker { Format = DateTimePickerFormat.Short, Font = fuente, Dock = DockStyle.Top, Value = valor };
            Agregar(barra, titulo, 140, fecha);
            return fecha;
        }

        public static TextBox AgregarTexto(Control barra, string titulo, int ancho)
        {
            var texto = new TextBox { Font = fuente, Dock = DockStyle.Top };
            Agregar(barra, titulo, ancho, texto);
            return texto;
        }

        public static Panel Agregar(Control barra, string titulo, int ancho, Control control)
        {
            var etiqueta = new Label
            {
                Text = titulo,
                Font = fuente,
                ForeColor = colorTexto,
                Dock = DockStyle.Left,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Width = TextRenderer.MeasureText(titulo, fuente).Width + 10
            };

            var contenedor = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 12, 0, 0) };
            contenedor.Controls.Add(control);

            var grupo = new Panel { Dock = DockStyle.Left, Width = etiqueta.Width + ancho + 16, Padding = new Padding(0, 0, 16, 0) };
            grupo.Controls.Add(contenedor);
            grupo.Controls.Add(etiqueta);

            barra.Controls.Add(grupo);
            int indice = barra.Controls.Count > 1 && barra.Controls[0].Dock == DockStyle.Fill ? 1 : 0;
            barra.Controls.SetChildIndex(grupo, indice);
            return grupo;
        }

        // el panel completo [titulo][control] de un filtro, para ocultarlo o mostrarlo
        public static Panel Grupo(Control control)
        {
            return (Panel)control.Parent.Parent;
        }

        // combo "Activos / Inactivos / Todos" -> true / false / null
        public static bool? Estado(ComboBox combo)
        {
            if (combo.SelectedIndex == 0) return true;
            if (combo.SelectedIndex == 1) return false;
            return null;
        }

        public static ComboBox AgregarEstado(Control barra)
        {
            return AgregarCombo(barra, "Estado:", 120, "Activos", "Inactivos", "Todos");
        }

        public static DateTime InicioDeMes()
        {
            return new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        }
    }
}
