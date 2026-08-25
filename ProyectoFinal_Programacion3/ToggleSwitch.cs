using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public class ToggleSwitch : Control
    {
        private bool activado;

        public bool Activado
        {
            get { return activado; }
            set
            {
                if (activado == value) return;
                activado = value;
                Invalidate();
                ActivadoChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ActivadoChanged;

        public ToggleSwitch()
        {
            DoubleBuffered = true;
            Cursor = Cursors.Hand;
            Size = new Size(48, 26);
            MinimumSize = new Size(40, 22);
            TabStop = true;
        }

        protected override void OnClick(EventArgs e)
        {
            Activado = !Activado;
            base.OnClick(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                Activado = !Activado;
                e.Handled = true;
            }
            base.OnKeyDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int alto = Height - 2;
            int ancho = Width - 2;
            var fondo = new Rectangle(1, 1, ancho, alto);
            int radio = alto;

            using (var ruta = new System.Drawing.Drawing2D.GraphicsPath())
            {
                ruta.AddArc(fondo.X, fondo.Y, radio, radio, 90, 180);
                ruta.AddArc(fondo.Right - radio, fondo.Y, radio, radio, 270, 180);
                ruta.CloseFigure();
                using (var brocha = new SolidBrush(Activado ? Color.FromArgb(39, 134, 56) : Color.FromArgb(180, 184, 196)))
                    e.Graphics.FillPath(brocha, ruta);
            }

            int diametro = alto - 6;
            int x = Activado ? Width - diametro - 4 : 4;
            using (var brocha = new SolidBrush(Color.White))
                e.Graphics.FillEllipse(brocha, x, 4, diametro, diametro);
        }
    }
}
