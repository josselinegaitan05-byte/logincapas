using System.Windows.Forms;
using Presentacion.Presentadores;
using Presentacion.Vistas;

namespace Presentacion.Formularios
{
    /// <summary>
    /// Pantalla de inicio (formulario hijo MDI) con el resumen de la sesión.
    /// </summary>
    public partial class frmInicio : Form, IInicioView
    {
        /// <summary>Crea el formulario y carga los datos con su presentador.</summary>
        public frmInicio()
        {
            InitializeComponent();
            new InicioPresenter(this).Iniciar();
        }

        /// <inheritdoc />
        public string Bienvenida { set { lblBienvenida.Text = value; } }

        /// <inheritdoc />
        public string Codigo { set { lblCodigoValor.Text = value; } }

        /// <inheritdoc />
        public string FechaCreacion { set { lblCreacionValor.Text = value; } }

        /// <inheritdoc />
        public string InicioSesion { set { lblSesionValor.Text = value; } }
    }
}
