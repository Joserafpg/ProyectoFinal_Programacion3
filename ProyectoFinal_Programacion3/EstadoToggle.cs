using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public static class EstadoToggle
    {
        public static void Reemplazar(Button botonAnterior, bool estadoInicial, string entidad, Func<bool, string> guardar)
        {
            Control padre = botonAnterior.Parent;
            int indice = padre.Controls.GetChildIndex(botonAnterior);
            botonAnterior.Visible = false;

            var panel = new Panel
            {
                Dock = botonAnterior.Dock,
                Height = botonAnterior.Height,
                BackColor = Color.White,
                Padding = new Padding(12, 8, 12, 8)
            };
            var etiqueta = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            var toggle = new ToggleSwitch
            {
                Dock = DockStyle.Right,
                Width = 52,
                Activado = estadoInicial
            };

            panel.Controls.Add(etiqueta);
            panel.Controls.Add(toggle);
            padre.Controls.Add(panel);
            padre.Controls.SetChildIndex(panel, indice);

            Action actualizarTexto = () =>
            {
                etiqueta.Text = "Estado: " + (toggle.Activado ? "Activo" : "Inactivo");
                etiqueta.ForeColor = toggle.Activado ? Color.FromArgb(39, 134, 56) : Color.FromArgb(130, 135, 158);
            };
            actualizarTexto();

            bool cambiando = false;
            toggle.ActivadoChanged += (s, e) =>
            {
                if (cambiando) return;
                bool nuevoEstado = toggle.Activado;
                string accion = nuevoEstado ? "activar" : "desactivar";

                if (MessageBox.Show("¿Está seguro de " + accion + " " + entidad + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    cambiando = true;
                    toggle.Activado = !nuevoEstado;
                    cambiando = false;
                    actualizarTexto();
                    return;
                }

                string error = guardar(nuevoEstado);
                if (!string.IsNullOrEmpty(error))
                {
                    cambiando = true;
                    toggle.Activado = !nuevoEstado;
                    cambiando = false;
                    MessageBox.Show(error, "No se pudo cambiar el estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(entidad + " ahora está " + (nuevoEstado ? "activo" : "inactivo") + ".", "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualizarTexto();
            };
        }
    }
}
