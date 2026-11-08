namespace Negocio.Contratos
{
    /// <summary>
    /// Contrato #1: su ÚNICA responsabilidad es GENERAR el hash de una contraseña.
    /// Se usa cuando un usuario se registra o cambia su contraseña.
    /// </summary>
    public interface IHashService
    {
        /// <summary>
        /// Genera el hash de una contraseña en texto plano.
        /// </summary>
        /// <param name="textoPlano">Contraseña tal como la escribió el usuario.</param>
        /// <returns>Hash en hexadecimal, listo para guardarse en la base de datos.</returns>
        string GenerarHash(string textoPlano);
    }
}
