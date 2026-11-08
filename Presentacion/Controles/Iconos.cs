using System.Drawing;
using System.Drawing.Text;

namespace Presentacion.Controles
{
    /// <summary>
    /// Genera íconos a partir de la fuente "Segoe MDL2 Assets" que trae Windows 10/11,
    /// así el proyecto no necesita archivos de imagen.
    /// </summary>
    public static class Iconos
    {
        /// <summary>Casa (Inicio).</summary>
        public const char Inicio = '';
        /// <summary>Agregar persona (Registrar usuario).</summary>
        public const char Usuario = '';
        /// <summary>Control de juego (Craps).</summary>
        public const char Juego = '';
        /// <summary>Apagar (Cerrar sesión).</summary>
        public const char Salir = '';

        /// <summary>Dibuja el glifo en un bitmap transparente del tamaño indicado.</summary>
        public static Bitmap Crear(char glifo, Color color, int tamano = 20)
        {
            Bitmap bmp = new Bitmap(tamano, tamano);
            using (Graphics g = Graphics.FromImage(bmp))
            using (Font fuente = new Font("Segoe MDL2 Assets", tamano * 0.75f, GraphicsUnit.Pixel))
            using (SolidBrush pincel = new SolidBrush(color))
            using (StringFormat centro = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                g.DrawString(glifo.ToString(), fuente, pincel, new RectangleF(0, 0, tamano, tamano), centro);
            }
            return bmp;
        }
    }
}
