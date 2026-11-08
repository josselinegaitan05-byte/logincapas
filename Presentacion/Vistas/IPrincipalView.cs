using System;

namespace Presentacion.Vistas
{
    /// <summary>
    /// Vista del formulario principal MDI con menú lateral.
    /// </summary>
    public interface IPrincipalView
    {
        /// <summary>Hora actual que se muestra en la barra superior.</summary>
        string Hora { set; }

        /// <summary>Fecha actual en texto largo.</summary>
        string Fecha { set; }

        /// <summary>Nombre del usuario en la parte inferior del menú lateral.</summary>
        string UsuarioSesion { set; }

        /// <summary>Detalle de la sesión (código y hora de inicio).</summary>
        string DetalleSesion { set; }

        /// <summary>Iniciales que se dibujan en el avatar.</summary>
        string Iniciales { set; }

        /// <summary>Se dispara cada segundo para refrescar la hora.</summary>
        event EventHandler RelojTick;

        /// <summary>Se dispara al pulsar "Cerrar sesión".</summary>
        event EventHandler CerrarSesionSolicitado;

        /// <summary>Pregunta si de verdad quiere cerrar sesión.</summary>
        bool ConfirmarCierreSesion();

        /// <summary>Cierra el formulario principal y vuelve al login.</summary>
        void VolverAlLogin();
    }
}
