using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Presentacion.Controles
{
    /// <summary>
    /// Círculo con las iniciales del usuario, usado en la parte inferior del menú lateral.
    /// </summary>
    public class AvatarControl : Control
    {
        private string _iniciales = "";

        /// <summary>Crea el avatar con doble búfer.</summary>
        public AvatarControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Size = new Size(44, 44);
        }

        /// <summary>Letras que se dibujan dentro del círculo.</summary>
        [DefaultValue("")]
        public string Iniciales
        {
            get { return _iniciales; }
            set { _iniciales = value ?? ""; Invalidate(); }
        }

        /// <inheritdoc />
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle circulo = new Rectangle(1, 1, Width - 3, Height - 3);
            using (SolidBrush relleno = new SolidBrush(Tema.MenuActivo))
                g.FillEllipse(relleno, circulo);

            using (Font fuente = new Font("Segoe UI", Height / 3.2f, FontStyle.Bold, GraphicsUnit.Pixel))
            using (SolidBrush texto = new SolidBrush(ForeColor))
            using (StringFormat centro = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.DrawString(_iniciales, fuente, texto, circulo, centro);
            }
        }
    }
}
