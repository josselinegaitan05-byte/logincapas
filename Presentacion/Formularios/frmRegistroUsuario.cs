using System;
using System.Drawing;
using System.Windows.Forms;
using Negocio;
using Presentacion.Presentadores;
using Presentacion.Vistas;

namespace Presentacion.Formularios
{
    /// <summary>
    /// Vista para registrar usuarios (formulario hijo MDI). La contraseña se convierte
    /// en hash en la capa de Negocio con IHashService antes de guardarse.
    /// </summary>
    public partial class frmRegistroUsuario : Form, IRegistroUsuarioView
    {
        private readonly RegistroUsuarioPresenter _presentador;

        /// <summary>Crea el formulario y su presentador.</summary>
        public frmRegistroUsuario()
        {
            InitializeComponent();
            _presentador = new RegistroUsuarioPresenter(this, Contenedor.CrearServicioUsuario());
        }

        /// <summary>Presentador asociado (útil para pruebas).</summary>
        public RegistroUsuarioPresenter Presentador { get { return _presentador; } }

        #region IRegistroUsuarioView

        /// <inheritdoc />
        public string Codigo { get { return txtCodigo.Text; } set { txtCodigo.Text = value; } }

        /// <inheritdoc />
        public string Usuario { get { return txtUsuario.Text; } set { txtUsuario.Text = value; } }

        /// <inheritdoc />
        public string Password { get { return txtPassword.Text; } set { txtPassword.Text = value; } }

        /// <inheritdoc />
        public string Confirmacion { get { return txtConfirmacion.Text; } set { txtConfirmacion.Text = value; } }

        /// <inheritdoc />
        public event EventHandler GuardarSolicitado;

        /// <inheritdoc />
        public event EventHandler LimpiarSolicitado;

        /// <inheritdoc />
        public void MostrarError(string mensaje, string campo)
        {
            MostrarMensaje(mensaje, Tema.Error);

            Control control = campo == N_Usuario.CampoCodigo ? (Control)txtCodigo
                            : campo == N_Usuario.CampoUsuario ? txtUsuario
                            : campo == N_Usuario.CampoPassword ? txtPassword
                            : campo == N_Usuario.CampoConfirmacion ? txtConfirmacion
                            : null;
            if (control != null)
            {
                errValidacion.SetError(control, mensaje);
                control.Focus();
            }
        }

        /// <inheritdoc />
        public void MostrarExito(string mensaje)
        {
            MostrarMensaje(mensaje, Tema.Exito);
        }

        /// <inheritdoc />
        public void LimpiarErrores()
        {
            lblMensaje.Visible = false;
            errValidacion.Clear();
        }

        /// <inheritdoc />
        public void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
            txtConfirmacion.Clear();
            txtCodigo.Focus();
        }

        #endregion

        private void MostrarMensaje(string mensaje, Color color)
        {
            lblMensaje.ForeColor = color;
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarSolicitado?.Invoke(this, EventArgs.Empty);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarSolicitado?.Invoke(this, EventArgs.Empty);
        }
    }
}
