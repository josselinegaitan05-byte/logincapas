namespace Negocio.Contratos
{
    /// <summary>
    /// Contrato #2: su ÚNICA responsabilidad es VERIFICAR si una contraseña en texto
    /// plano coincide con el hash almacenado. Se usa cuando el usuario inicia sesión.
    /// </summary>
    public interface IVerificarHashService
    {
        /// <summary>
        /// Comprueba una contraseña contra el hash guardado en la base de datos.
        /// </summary>
        /// <param name="textoPlano">Contraseña que escribió el usuario en el login.</param>
        /// <param name="hashAlmacenado">Hash en hexadecimal leído de la base de datos.</param>
        /// <returns>true si la contraseña es correcta.</returns>
        bool Verificar(string textoPlano, string hashAlmacenado);
    }
}
