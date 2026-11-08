using System;
using System.Windows.Forms;
using Negocio;
using Presentacion.Presentadores;
using Presentacion.Vistas;

namespace Presentacion.Formularios
{
    /// <summary>
    /// Vista del juego de Craps (formulario hijo MDI). Las reglas están en N_Craps (Negocio).
    /// </summary>
    public partial class frmCraps : Form, ICrapsView
    {
        private readonly CrapsPresenter _presentador;

        /// <summary>Crea el formulario con un juego nuevo.</summary>
        public frmCraps() : this(new N_Craps())
        {
        }

        /// <summary>Crea el formulario con el juego indicado (permite fijar la semilla en pruebas).</summary>
        public frmCraps(N_Craps juego)
        {
            InitializeComponent();
            _presentador = new CrapsPresenter(this, juego);
            _presentador.Iniciar();
        }

        /// <summary>Presentador asociado (útil para pruebas).</summary>
        public CrapsPresenter Presentador { get { return _presentador; } }

        #region ICrapsView

        /// <inheritdoc />
        public event EventHandler LanzarSolicitado;

        /// <inheritdoc />
        public event EventHandler NuevoJuegoSolicitado;

        /// <inheritdoc />
        public void MostrarDados(int dado1, int dado2)
        {
            dado1Control.Valor = dado1;
            dado2Control.Valor = dado2;
        }

        /// <inheritdoc />
        public string Suma { set { lblSumaValor.Text = value; } }

        /// <inheritdoc />
        public string Punto { set { lblPuntoValor.Text = value; } }

        /// <inheritdoc />
        public string Lanzamientos { set { lblLanzamientosValor.Text = value; } }

        /// <inheritdoc />
        public string Marcador { set { lblMarcador.Text = value; } }

        /// <inheritdoc />
        public void MostrarMensaje(string mensaje, EstadoCraps estado)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.ForeColor = estado == EstadoCraps.Gana ? Tema.Exito
                                 : estado == EstadoCraps.Pierde ? Tema.Error
                                 : estado == EstadoCraps.Continua ? Tema.Aviso
                                 : Tema.TextoSuave;
        }

        #endregion

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            LanzarSolicitado?.Invoke(this, EventArgs.Empty);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoJuegoSolicitado?.Invoke(this, EventArgs.Empty);
        }
    }
}
