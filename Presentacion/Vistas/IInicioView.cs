namespace Presentacion.Vistas
{
    /// <summary>
    /// Vista de la pantalla de inicio (formulario hijo MDI) con el resumen de la sesión.
    /// </summary>
    public interface IInicioView
    {
        /// <summary>Saludo principal.</summary>
        string Bienvenida { set; }

        /// <summary>Código del usuario.</summary>
        string Codigo { set; }

        /// <summary>Fecha en que se creó el usuario.</summary>
        string FechaCreacion { set; }

        /// <summary>Hora de inicio de la sesión.</summary>
        string InicioSesion { set; }
    }
}
