using System;
using System.Windows.Forms;
using Presentacion.Formularios;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>Punto de entrada: el formulario de inicio es el login.</summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
