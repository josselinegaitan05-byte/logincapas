using System;

namespace Presentacion.Vistas
{
    /// <summary>
    /// Vista para registrar un usuario nuevo (aquí se usa IHashService.GenerarHash).
    /// </summary>
    public interface IRegistroUsuarioView
    {
        /// <summary>Código escrito.</summary>
        string Codigo { get; }

        /// <summary>Nombre de usuario escrito.</summary>
        string Usuario { get; }

        /// <summary>Contraseña escrita.</summary>
        string Password { get; }

        /// <summary>Confirmación de la contraseña.</summary>
        string Confirmacion { get; }

        /// <summary>Se dispara al pulsar "Guardar".</summary>
        event EventHandler GuardarSolicitado;

        /// <summary>Se dispara al pulsar "Limpiar".</summary>
        event EventHandler LimpiarSolicitado;

        /// <summary>Muestra un error de validación y marca el campo.</summary>
        void MostrarError(string mensaje, string campo);

        /// <summary>Muestra el mensaje de éxito.</summary>
        void MostrarExito(string mensaje);

        /// <summary>Quita mensajes y marcas.</summary>
        void LimpiarErrores();

        /// <summary>Deja el formulario en blanco.</summary>
        void LimpiarCampos();
    }
}
