using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Presentacion.Controles
{
    /// <summary>
    /// Control que dibuja un dado con sus puntos (1 a 6). Valor 0 = dado vacío.
    /// </summary>
    public class DadoControl : Control
    {
        private int _valor;

        /// <summary>Crea el dado con doble búfer para que no parpadee.</summary>
        public DadoControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            Size = new Size(110, 110);
        }

        /// <summary>Cara visible del dado (0 a 6).</summary>
        [DefaultValue(0)]
        public int Valor
        {
            get { return _valor; }
            set { _valor = value < 0 || value > 6 ? 0 : value; Invalidate(); }
        }

        /// <inheritdoc />
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int lado = System.Math.Min(Width, Height) - 4;
            Rectangle caja = new Rectangle((Width - lado) / 2, (Height - lado) / 2, lado, lado);

            using (GraphicsPath forma = Redondeado(caja, lado / 6))
            using (SolidBrush relleno = new SolidBrush(_valor == 0 ? Color.FromArgb(235, 238, 243) : Color.White))
            using (Pen borde = new Pen(Color.FromArgb(160, 170, 185), 2))
            {
                g.FillPath(relleno, forma);
                g.DrawPath(borde, forma);
            }

            if (_valor == 0)
                return;

            float r = lado / 10f;
            float izq = caja.Left + lado * 0.25f, cen = caja.Left + lado * 0.5f, der = caja.Left + lado * 0.75f;
            float arr = caja.Top + lado * 0.25f, med = caja.Top + lado * 0.5f, aba = caja.Top + lado * 0.75f;

            using (SolidBrush punto = new SolidBrush(Color.FromArgb(20, 39, 78)))
            {
                if (_valor % 2 == 1) Punto(g, punto, cen, med, r);
                if (_valor >= 2) { Punto(g, punto, izq, arr, r); Punto(g, punto, der, aba, r); }
                if (_valor >= 4) { Punto(g, punto, der, arr, r); Punto(g, punto, izq, aba, r); }
                if (_valor == 6) { Punto(g, punto, izq, med, r); Punto(g, punto, der, med, r); }
            }
        }

        private static void Punto(Graphics g, Brush b, float x, float y, float r)
        {
            g.FillEllipse(b, x - r, y - r, 2 * r, 2 * r);
        }

        private static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            int d = radio * 2;
            GraphicsPath p = new GraphicsPath();
            p.AddArc(r.Left, r.Top, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Top, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.Left, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }
}
