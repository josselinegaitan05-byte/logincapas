using System;
using Negocio;
using Presentacion.Vistas;

namespace Presentacion.Presentadores
{
    /// <summary>
    /// Presentador del login: recibe la acción de la Vista, le pide a Negocio que verifique
    /// la contraseña (IVerificarHashService) y le dice a la Vista qué mostrar.
    /// </summary>
    public class LoginPresenter
    {
        private readonly ILoginView _vista;
        private readonly N_Usuario _servicio;

        /// <summary>Conecta el presentador con su vista y el servicio de usuarios.</summary>
        public LoginPresenter(ILoginView vista, N_Usuario servicio)
        {
            _vista = vista ?? throw new ArgumentNullException(nameof(vista));
            _servicio = servicio ?? throw new ArgumentNullException(nameof(servicio));
            _vista.IniciarSesionSolicitado += (s, e) => IniciarSesion();
        }

        /// <summary>Valida las credenciales y abre el menú o muestra el error.</summary>
        public void IniciarSesion()
        {
            _vista.LimpiarErrores();

            ResultadoOperacion resultado = _servicio.IniciarSesion(_vista.Usuario, _vista.Password);

            if (!resultado.Exitoso)
            {
                _vista.MostrarError(resultado.Mensaje, resultado.Campo);
                if (resultado.Campo == N_Usuario.CampoPassword)
                    _vista.LimpiarPassword();
                return;
            }

            SesionActual.Iniciar(resultado.Usuario);
            _vista.LimpiarPassword();
            _vista.AbrirMenuPrincipal();
        }
    }
}
