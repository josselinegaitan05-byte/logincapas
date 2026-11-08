using System;
using Negocio;
using Presentacion.Vistas;

namespace Presentacion.Presentadores
{
    /// <summary>
    /// Presentador del juego de Craps: pide al modelo (N_Craps) que lance y le dice
    /// a la Vista qué dados, punto y mensaje mostrar.
    /// </summary>
    public class CrapsPresenter
    {
        private readonly ICrapsView _vista;
        private readonly N_Craps _juego;

        /// <summary>Conecta el presentador con su vista y el modelo del juego.</summary>
        public CrapsPresenter(ICrapsView vista, N_Craps juego)
        {
            _vista = vista ?? throw new ArgumentNullException(nameof(vista));
            _juego = juego ?? throw new ArgumentNullException(nameof(juego));

            _vista.LanzarSolicitado += (s, e) => Lanzar();
            _vista.NuevoJuegoSolicitado += (s, e) => NuevoJuego();
        }

        /// <summary>Deja la mesa lista para empezar.</summary>
        public void Iniciar()
        {
            Refrescar("Pulse \"Lanzar dados\" para empezar. 7 u 11 gana; 2, 3 o 12 pierde.");
        }

        /// <summary>Lanza los dados y muestra el resultado.</summary>
        public void Lanzar()
        {
            EstadoCraps estado = _juego.Lanzar();
            string mensaje;

            switch (estado)
            {
                case EstadoCraps.Gana:
                    mensaje = _juego.Lanzamientos == 1
                        ? "¡Ganaste! Sacaste " + _juego.Suma + " en el primer lanzamiento."
                        : "¡Ganaste! Volviste a sacar el punto " + _juego.Punto + ".";
                    break;
                case EstadoCraps.Pierde:
                    mensaje = _juego.Lanzamientos == 1
                        ? "Perdiste: sacaste " + _juego.Suma + " (craps) en el primer lanzamiento."
                        : "Perdiste: salió 7 antes que el punto " + _juego.Punto + ".";
                    break;
                default:
                    mensaje = _juego.Lanzamientos == 1
                        ? "Tu punto es " + _juego.Punto + ". Sigue lanzando hasta sacarlo antes de un 7."
                        : "Sacaste " + _juego.Suma + ". Sigue lanzando: necesitas " + _juego.Punto + ".";
                    break;
            }
            Refrescar(mensaje);
        }

        /// <summary>Reinicia el juego y el marcador.</summary>
        public void NuevoJuego()
        {
            _juego.Reiniciar();
            Iniciar();
        }

        private void Refrescar(string mensaje)
        {
            _vista.MostrarDados(_juego.Dado1, _juego.Dado2);
            _vista.Suma = _juego.Lanzamientos == 0 ? "—" : _juego.Suma.ToString();
            _vista.Punto = _juego.Punto == 0 ? "—" : _juego.Punto.ToString();
            _vista.Lanzamientos = _juego.Lanzamientos.ToString();
            _vista.Marcador = "Ganadas " + _juego.Ganadas + "  ·  Perdidas " + _juego.Perdidas;
            _vista.MostrarMensaje(mensaje, _juego.Estado);
        }
    }
}
