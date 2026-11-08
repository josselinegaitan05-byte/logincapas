using System;
using System.Globalization;
using Negocio;
using Presentacion.Vistas;

namespace Presentacion.Presentadores
{
    /// <summary>
    /// Presentador de la pantalla de inicio: llena el resumen con los datos de la sesión.
    /// </summary>
    public class InicioPresenter
    {
        private static readonly CultureInfo Espanol = new CultureInfo("es-PA");
        private readonly IInicioView _vista;

        /// <summary>Conecta el presentador con su vista.</summary>
        public InicioPresenter(IInicioView vista)
        {
            _vista = vista ?? throw new ArgumentNullException(nameof(vista));
        }

        /// <summary>Muestra los datos del usuario en sesión.</summary>
        public void Iniciar()
        {
            if (!SesionActual.Activa)
                return;

            _vista.Bienvenida = "¡Bienvenido, " + SesionActual.Usuario.dsUsuario + "!";
            _vista.Codigo = SesionActual.Usuario.dsId;
            _vista.FechaCreacion = SesionActual.Usuario.dtFechaCreacion.ToString("dd/MM/yyyy", Espanol);
            _vista.InicioSesion = SesionActual.Inicio.ToString("hh:mm tt", Espanol);
        }
    }
}
