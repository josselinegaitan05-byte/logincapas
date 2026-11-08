using System;

namespace Presentacion.Vistas
{
    /// <summary>
    /// Vista del login (MVP). El formulario solo expone lo que escribe el usuario,
    /// avisa cuando pulsa "Ingresar" y muestra lo que el presentador le indique.
    /// No sabe nada de hash ni de base de datos.
    /// </summary>
    public interface ILoginView
    {
        /// <summary>Texto escrito en el campo usuario.</summary>
        string Usuario { get; }

        /// <summary>Texto escrito en el campo contraseña.</summary>
        string Password { get; }

        /// <summary>Se dispara al pulsar "Ingresar" o Enter.</summary>
        event EventHandler IniciarSesionSolicitado;

        /// <summary>Muestra un mensaje de validación y marca el campo indicado.</summary>
        void MostrarError(string mensaje, string campo);

        /// <summary>Quita los mensajes y marcas de error.</summary>
        void LimpiarErrores();

        /// <summary>Borra la contraseña escrita.</summary>
        void LimpiarPassword();

        /// <summary>Abre el menú principal (el login queda oculto).</summary>
        void AbrirMenuPrincipal();
    }
}
