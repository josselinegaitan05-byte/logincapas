using System;
using Negocio;

namespace Presentacion.Vistas
{
    /// <summary>
    /// Vista del juego de Craps (formulario hijo MDI).
    /// </summary>
    public interface ICrapsView
    {
        /// <summary>Se dispara al pulsar "Lanzar dados".</summary>
        event EventHandler LanzarSolicitado;

        /// <summary>Se dispara al pulsar "Nuevo juego".</summary>
        event EventHandler NuevoJuegoSolicitado;

        /// <summary>Dibuja los dos dados (0 = dado vacío).</summary>
        void MostrarDados(int dado1, int dado2);

        /// <summary>Texto de la suma.</summary>
        string Suma { set; }

        /// <summary>Texto del punto.</summary>
        string Punto { set; }

        /// <summary>Texto del número de lanzamientos.</summary>
        string Lanzamientos { set; }

        /// <summary>Texto del marcador de partidas.</summary>
        string Marcador { set; }

        /// <summary>Muestra el resultado de la jugada con el color de su estado.</summary>
        void MostrarMensaje(string mensaje, EstadoCraps estado);
    }
}
