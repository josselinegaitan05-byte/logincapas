using Entidades;

namespace Negocio
{
    /// <summary>
    /// Resultado de una operación de negocio (login o registro): indica si salió bien,
    /// el mensaje para el usuario y, en el login, el usuario autenticado.
    /// </summary>
    public class ResultadoOperacion
    {
        /// <summary>true si la operación se completó.</summary>
        public bool Exitoso { get; private set; }

        /// <summary>Mensaje listo para mostrar en la Vista.</summary>
        public string Mensaje { get; private set; }

        /// <summary>Campo de la vista que causó el error (para marcarlo), o null.</summary>
        public string Campo { get; private set; }

        /// <summary>Usuario autenticado o registrado (solo si Exitoso).</summary>
        public E_Usuario Usuario { get; private set; }

        /// <summary>Crea un resultado correcto.</summary>
        public static ResultadoOperacion Ok(string mensaje, E_Usuario usuario = null)
        {
            return new ResultadoOperacion { Exitoso = true, Mensaje = mensaje, Usuario = usuario };
        }

        /// <summary>Crea un resultado con error de validación o de sistema.</summary>
        public static ResultadoOperacion Error(string mensaje, string campo = null)
        {
            return new ResultadoOperacion { Exitoso = false, Mensaje = mensaje, Campo = campo };
        }
    }
}
