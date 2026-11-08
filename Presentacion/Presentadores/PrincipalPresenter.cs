using System;
using System.Globalization;
using Entidades;
using Negocio;
using Presentacion.Vistas;

namespace Presentacion.Presentadores
{
    /// <summary>
    /// Presentador del formulario principal: actualiza la hora y muestra quién inició sesión.
    /// </summary>
    public class PrincipalPresenter
    {
        private static readonly CultureInfo Espanol = new CultureInfo("es-PA");

        private readonly IPrincipalView _vista;
        private readonly Func<DateTime> _reloj;

        /// <summary>Crea el presentador. <paramref name="reloj"/> permite fijar la hora en pruebas.</summary>
        public PrincipalPresenter(IPrincipalView vista, Func<DateTime> reloj = null)
        {
            _vista = vista ?? throw new ArgumentNullException(nameof(vista));
            _reloj = reloj ?? (() => DateTime.Now);

            _vista.RelojTick += (s, e) => ActualizarHora();
            _vista.CerrarSesionSolicitado += (s, e) => CerrarSesion();
        }

        /// <summary>Carga los datos de la sesión y la hora inicial.</summary>
        public void Iniciar()
        {
            E_Usuario usuario = SesionActual.Usuario;
            if (usuario != null)
            {
                _vista.UsuarioSesion = usuario.dsUsuario;
                _vista.DetalleSesion = "Código " + usuario.dsId + "\r\nEntró a las " +
                                       SesionActual.Inicio.ToString("hh:mm tt", Espanol);
                _vista.Iniciales = usuario.dsUsuario.Substring(0, Math.Min(2, usuario.dsUsuario.Length)).ToUpper();
            }
            ActualizarHora();
        }

        /// <summary>Muestra la hora y la fecha actuales.</summary>
        public void ActualizarHora()
        {
            DateTime ahora = _reloj();
            _vista.Hora = ahora.ToString("hh:mm:ss tt", Espanol);
            string fecha = ahora.ToString("dddd, d 'de' MMMM 'de' yyyy", Espanol);
            _vista.Fecha = char.ToUpper(fecha[0]) + fecha.Substring(1);
        }

        /// <summary>Cierra la sesión si el usuario lo confirma.</summary>
        public void CerrarSesion()
        {
            if (!_vista.ConfirmarCierreSesion())
                return;

            SesionActual.Cerrar();
            _vista.VolverAlLogin();
        }
    }
}
