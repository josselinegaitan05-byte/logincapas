using System;
using System.Windows.Forms;
using Negocio;
using Presentacion.Presentadores;
using Presentacion.Vistas;

namespace Presentacion.Formularios
{
    /// <summary>
    /// Vista del login. Implementa <see cref="ILoginView"/>: solo maneja controles y
    /// delega todo al <see cref="LoginPresenter"/>.
    /// </summary>
    public partial class frmLogin : Form, ILoginView
    {
        private readonly LoginPresenter _presentador;

        /// <summary>Crea el formulario y su presentador.</summary>
        public frmLogin()
        {
            InitializeComponent();
            _presentador = new LoginPresenter(this, Contenedor.CrearServicioUsuario());
        }

        /// <summary>Presentador asociado (útil para pruebas).</summary>
        public LoginPresenter Presentador { get { return _presentador; } }

        #region ILoginView

        /// <inheritdoc />
        public string Usuario
        {
            get { return txtUsuario.Text; }
            set { txtUsuario.Text = value; }
        }

        /// <inheritdoc />
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        /// <inheritdoc />
        public event EventHandler IniciarSesionSolicitado;

        /// <inheritdoc />
        public void MostrarError(string mensaje, string campo)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;

            Control control = campo == N_Usuario.CampoUsuario ? (Control)txtUsuario
                            : campo == N_Usuario.CampoPassword ? txtPassword
                            : null;
            if (control != null)
            {
                errValidacion.SetError(control, mensaje);
                control.Focus();
            }
        }

        /// <inheritdoc />
        public void LimpiarErrores()
        {
            lblMensaje.Visible = false;
            errValidacion.Clear();
        }

        /// <inheritdoc />
        public void LimpiarPassword()
        {
            txtPassword.Clear();
        }

        /// <inheritdoc />
        public void AbrirMenuPrincipal()
        {
            frmPrincipal principal = new frmPrincipal();
            // Al cerrar el principal (cerrar sesión o la X) se vuelve al login
            principal.FormClosed += (s, e) =>
            {
                txtUsuario.Clear();
                Show();
                txtUsuario.Focus();
            };
            Hide();
            principal.Show();
        }

        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesionSolicitado?.Invoke(this, EventArgs.Empty);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkMostrar.Checked;
        }
    }
}
