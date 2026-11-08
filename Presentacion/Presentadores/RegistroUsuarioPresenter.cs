using System;
using Negocio;
using Presentacion.Vistas;

namespace Presentacion.Presentadores
{
    /// <summary>
    /// Presentador del registro de usuarios: le pide a Negocio validar y generar el hash
    /// (IHashService) y le indica a la Vista el resultado.
    /// </summary>
    public class RegistroUsuarioPresenter
    {
        private readonly IRegistroUsuarioView _vista;
        private readonly N_Usuario _servicio;

        /// <summary>Conecta el presentador con su vista y el servicio de usuarios.</summary>
        public RegistroUsuarioPresenter(IRegistroUsuarioView vista, N_Usuario servicio)
        {
            _vista = vista ?? throw new ArgumentNullException(nameof(vista));
            _servicio = servicio ?? throw new ArgumentNullException(nameof(servicio));

            _vista.GuardarSolicitado += (s, e) => Guardar();
            _vista.LimpiarSolicitado += (s, e) => { _vista.LimpiarErrores(); _vista.LimpiarCampos(); };
        }

        /// <summary>Valida y guarda el usuario nuevo.</summary>
        public void Guardar()
        {
            _vista.LimpiarErrores();

            string creadoPor = SesionActual.Activa ? SesionActual.Usuario.dsUsuario : "Sistema";
            ResultadoOperacion resultado = _servicio.Registrar(
                _vista.Codigo, _vista.Usuario, _vista.Password, _vista.Confirmacion, creadoPor);

            if (!resultado.Exitoso)
            {
                _vista.MostrarError(resultado.Mensaje, resultado.Campo);
                return;
            }

            _vista.LimpiarCampos();
            _vista.MostrarExito(resultado.Mensaje);
        }
    }
}
