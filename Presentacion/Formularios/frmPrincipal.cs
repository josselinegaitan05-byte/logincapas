using System;
using System.Linq;
using System.Windows.Forms;
using Negocio;
using Presentacion.Controles;
using Presentacion.Presentadores;
using Presentacion.Vistas;

namespace Presentacion.Formularios
{
    /// <summary>
    /// Formulario principal MDI con menú lateral a la izquierda, hora actual en la barra
    /// superior y el usuario de la sesión en la parte inferior del menú.
    /// </summary>
    public partial class frmPrincipal : Form, IPrincipalView
    {
        private readonly PrincipalPresenter _presentador;
        private Button _botonActivo;

        /// <summary>Crea el formulario, su presentador y abre la pantalla de inicio.</summary>
        public frmPrincipal()
        {
            InitializeComponent();

            // Color de fondo del área MDI donde se abren los formularios hijos
            foreach (MdiClient mdi in Controls.OfType<MdiClient>())
                mdi.BackColor = Tema.Fondo;

            btnInicio.Image = Iconos.Crear(Iconos.Inicio, Tema.TextoMenu);
            btnUsuarios.Image = Iconos.Crear(Iconos.Usuario, Tema.TextoMenu);
            btnCraps.Image = Iconos.Crear(Iconos.Juego, Tema.TextoMenu);
            btnCerrarSesion.Image = Iconos.Crear(Iconos.Salir, Tema.TextoMenu, 16);

            _presentador = new PrincipalPresenter(this);
            _presentador.Iniciar();
        }

        #region IPrincipalView

        /// <inheritdoc />
        public string Hora { set { lblHora.Text = value; } }

        /// <inheritdoc />
        public string Fecha { set { lblFecha.Text = value; } }

        /// <inheritdoc />
        public string UsuarioSesion { set { lblUsuarioSesion.Text = value; } }

        /// <inheritdoc />
        public string DetalleSesion { set { lblDetalleSesion.Text = value; } }

        /// <inheritdoc />
        public string Iniciales { set { avatar.Iniciales = value; } }

        /// <inheritdoc />
        public event EventHandler RelojTick;

        /// <inheritdoc />
        public event EventHandler CerrarSesionSolicitado;

        /// <inheritdoc />
        public bool ConfirmarCierreSesion()
        {
            return MessageBox.Show("¿Desea cerrar la sesión?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <inheritdoc />
        public void VolverAlLogin()
        {
            Close(); // el login se vuelve a mostrar en su evento FormClosed
        }

        #endregion

        /// <summary>
        /// Abre un formulario hijo dentro del área MDI. Si ya está abierto lo trae al frente;
        /// los demás se cierran para que solo haya uno visible.
        /// </summary>
        public T AbrirFormulario<T>(Func<T> crear, Button boton, string titulo) where T : Form
        {
            MarcarBoton(boton);
            lblSeccion.Text = titulo;

            T existente = MdiChildren.OfType<T>().FirstOrDefault();
            foreach (Form hijo in MdiChildren.Where(f => f != existente).ToList())
                hijo.Close();

            if (existente != null)
            {
                existente.Activate();
                return existente;
            }

            T formulario = crear();
            formulario.MdiParent = this;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.ControlBox = false;
            // Acoplado en lugar de maximizado: un hijo MDI maximizado agrega una barra de control gris
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
            return formulario;
        }

        private void MarcarBoton(Button boton)
        {
            if (_botonActivo != null)
                _botonActivo.BackColor = Tema.Menu;
            _botonActivo = boton;
            if (_botonActivo != null)
                _botonActivo.BackColor = Tema.MenuActivo;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario(() => new frmInicio(), btnInicio, "Inicio");
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            RelojTick?.Invoke(this, EventArgs.Empty);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(() => new frmInicio(), btnInicio, "Inicio");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(() => new frmRegistroUsuario(), btnUsuarios, "Registrar usuario");
        }

        private void btnCraps_Click(object sender, EventArgs e)
        {
            AbrirFormulario(() => new frmCraps(), btnCraps, "Juego de Craps");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesionSolicitado?.Invoke(this, EventArgs.Empty);
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrReloj.Stop();
            SesionActual.Cerrar();
        }
    }
}
