using System;
using Entidades;

namespace Negocio
{
    /// <summary>
    /// Guarda quién inició sesión, para mostrarlo en la parte inferior del menú lateral
    /// y para registrar quién crea nuevos usuarios.
    /// </summary>
    public static class SesionActual
    {
        /// <summary>Usuario autenticado, o null si no hay sesión.</summary>
        public static E_Usuario Usuario { get; private set; }

        /// <summary>Fecha y hora en que se inició la sesión.</summary>
        public static DateTime Inicio { get; private set; }

        /// <summary>true si hay un usuario con sesión iniciada.</summary>
        public static bool Activa
        {
            get { return Usuario != null; }
        }

        /// <summary>Abre la sesión del usuario indicado.</summary>
        public static void Iniciar(E_Usuario usuario)
        {
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            Inicio = DateTime.Now;
        }

        /// <summary>Cierra la sesión.</summary>
        public static void Cerrar()
        {
            Usuario = null;
        }
    }
}
