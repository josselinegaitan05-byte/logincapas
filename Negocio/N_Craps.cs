using System;

namespace Negocio
{
    /// <summary>Estado de una partida de Craps.</summary>
    public enum EstadoCraps
    {
        /// <summary>Todavía no se ha lanzado (o se reinició).</summary>
        SinIniciar,
        /// <summary>Se estableció un punto y hay que seguir lanzando.</summary>
        Continua,
        /// <summary>El jugador ganó.</summary>
        Gana,
        /// <summary>El jugador perdió.</summary>
        Pierde
    }

    /// <summary>
    /// Modelo del juego de Craps (reglas en la capa de Negocio, no en el formulario).
    /// </summary>
    /// <remarks>
    /// Primer lanzamiento: 7 u 11 gana; 2, 3 o 12 pierde; cualquier otro valor se convierte
    /// en el "punto". Después se sigue lanzando: si sale el punto gana, si sale 7 pierde.
    /// </remarks>
    public class N_Craps
    {
        private readonly Random _random;

        /// <summary>Crea el juego. Se puede pasar un Random con semilla para pruebas.</summary>
        public N_Craps(Random random = null)
        {
            _random = random ?? new Random();
            Reiniciar();
        }

        /// <summary>Valor del primer dado del último lanzamiento.</summary>
        public int Dado1 { get; private set; }
        /// <summary>Valor del segundo dado del último lanzamiento.</summary>
        public int Dado2 { get; private set; }
        /// <summary>Suma del último lanzamiento.</summary>
        public int Suma { get { return Dado1 + Dado2; } }
        /// <summary>Punto establecido (0 si no hay).</summary>
        public int Punto { get; private set; }
        /// <summary>Cantidad de lanzamientos de la partida actual.</summary>
        public int Lanzamientos { get; private set; }
        /// <summary>Estado actual de la partida.</summary>
        public EstadoCraps Estado { get; private set; }
        /// <summary>Partidas ganadas en la sesión.</summary>
        public int Ganadas { get; private set; }
        /// <summary>Partidas perdidas en la sesión.</summary>
        public int Perdidas { get; private set; }

        /// <summary>true si la partida terminó (ganó o perdió).</summary>
        public bool Terminada
        {
            get { return Estado == EstadoCraps.Gana || Estado == EstadoCraps.Pierde; }
        }

        /// <summary>Lanza los dos dados y aplica las reglas.</summary>
        public EstadoCraps Lanzar()
        {
            if (Terminada)
                NuevaPartida();

            Dado1 = _random.Next(1, 7);
            Dado2 = _random.Next(1, 7);
            Lanzamientos++;

            if (Punto == 0)
            {
                switch (Suma)
                {
                    case 7:
                    case 11:
                        Estado = EstadoCraps.Gana;
                        break;
                    case 2:
                    case 3:
                    case 12:
                        Estado = EstadoCraps.Pierde;
                        break;
                    default:
                        Punto = Suma;
                        Estado = EstadoCraps.Continua;
                        break;
                }
            }
            else if (Suma == Punto)
            {
                Estado = EstadoCraps.Gana;
            }
            else if (Suma == 7)
            {
                Estado = EstadoCraps.Pierde;
            }

            if (Estado == EstadoCraps.Gana) Ganadas++;
            if (Estado == EstadoCraps.Pierde) Perdidas++;
            return Estado;
        }

        /// <summary>Empieza otra partida conservando el marcador.</summary>
        public void NuevaPartida()
        {
            Dado1 = 0;
            Dado2 = 0;
            Punto = 0;
            Lanzamientos = 0;
            Estado = EstadoCraps.SinIniciar;
        }

        /// <summary>Empieza de cero, incluido el marcador.</summary>
        public void Reiniciar()
        {
            NuevaPartida();
            Ganadas = 0;
            Perdidas = 0;
        }
    }
}
