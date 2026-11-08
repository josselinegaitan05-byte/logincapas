using Entidades;

namespace Datos
{
    /// <summary>
    /// Contrato de acceso a datos de usuarios. La capa de Negocio depende de esta
    /// interfaz y no de MySQL directamente, así se puede probar con un repositorio falso.
    /// </summary>
    public interface IUsuarioRepositorio
    {
        /// <summary>
        /// Busca un usuario por su nombre (activo o inactivo).
        /// Devuelve null si no existe.
        /// </summary>
        E_Usuario ObtenerPorUsuario(string dsUsuario);

        /// <summary>
        /// Inserta un usuario nuevo. <see cref="E_Usuario.dsPassword"/> debe traer el hash, no la clave.
        /// Devuelve el id generado.
        /// </summary>
        int Insertar(E_Usuario usuario);
    }
}
