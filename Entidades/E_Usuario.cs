using System;

namespace Entidades
{
    /// <summary>
    /// Capa de Entidades: representa una fila de la tabla <c>usuarios</c>.
    /// Es una clase pura de datos (DTO): no tiene lógica ni acceso a la base de datos.
    /// </summary>
    public class E_Usuario
    {
        /// <summary>Llave primaria autoincremental.</summary>
        public int id { get; set; }

        /// <summary>Código del usuario (por ejemplo "001").</summary>
        public string dsId { get; set; }

        /// <summary>Nombre de usuario con el que se inicia sesión (único).</summary>
        public string dsUsuario { get; set; }

        /// <summary>Hash SHA-512 de la contraseña en hexadecimal (128 caracteres). Nunca la contraseña en texto plano.</summary>
        public string dsPassword { get; set; }

        /// <summary>'1' = activo, '0' = inactivo.</summary>
        public char dsEstado { get; set; }

        /// <summary>Usuario que creó el registro.</summary>
        public string dsUsuarioCreacion { get; set; }

        /// <summary>Fecha de creación del registro.</summary>
        public DateTime dtFechaCreacion { get; set; }

        /// <summary>Usuario que hizo la última modificación.</summary>
        public string dsUsuarioModificacion { get; set; }

        /// <summary>Fecha de la última modificación.</summary>
        public DateTime dtFechaModificacion { get; set; }

        /// <summary>Indica si el usuario está activo (dsEstado = '1').</summary>
        public bool EstaActivo
        {
            get { return dsEstado == '1'; }
        }
    }
}
