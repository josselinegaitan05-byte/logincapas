using System.Drawing;

namespace Presentacion
{
    /// <summary>
    /// Colores y fuentes compartidos por todos los formularios, para que el diseño sea uniforme.
    /// </summary>
    public static class Tema
    {
        /// <summary>Fondo del menú lateral.</summary>
        public static readonly Color Menu = Color.FromArgb(20, 39, 78);
        /// <summary>Botón del menú al pasar el mouse.</summary>
        public static readonly Color MenuHover = Color.FromArgb(33, 58, 110);
        /// <summary>Botón del menú seleccionado.</summary>
        public static readonly Color MenuActivo = Color.FromArgb(0, 120, 212);
        /// <summary>Color de acento (botones principales).</summary>
        public static readonly Color Acento = Color.FromArgb(0, 120, 212);
        /// <summary>Fondo del área de trabajo.</summary>
        public static readonly Color Fondo = Color.FromArgb(243, 246, 250);
        /// <summary>Fondo de tarjetas.</summary>
        public static readonly Color Tarjeta = Color.White;
        /// <summary>Texto principal.</summary>
        public static readonly Color Texto = Color.FromArgb(32, 33, 36);
        /// <summary>Texto secundario.</summary>
        public static readonly Color TextoSuave = Color.FromArgb(95, 99, 104);
        /// <summary>Texto claro sobre el menú.</summary>
        public static readonly Color TextoMenu = Color.FromArgb(214, 224, 240);
        /// <summary>Color de error.</summary>
        public static readonly Color Error = Color.FromArgb(196, 43, 28);
        /// <summary>Color de éxito.</summary>
        public static readonly Color Exito = Color.FromArgb(16, 124, 16);
        /// <summary>Color de advertencia/continúa.</summary>
        public static readonly Color Aviso = Color.FromArgb(157, 93, 0);
    }
}
