namespace Datos
{
    /// <summary>
    /// Conexión específica de la aplicación a MySQL con privilegios mínimos.
    /// </summary>
    /// <remarks>
    /// Se usa el usuario <c>usr_login</c> (script BaseDatos/02_usuario_acceso_bd.sql), que solo
    /// tiene permiso EXECUTE sobre sp_ObtenerUsuarioLogin y sp_InsertarUsuario; no puede leer
    /// ni modificar la tabla directamente.
    /// <c>CheckParameters=false</c> evita que el conector pida los metadatos del procedimiento,
    /// que un usuario con solo EXECUTE no puede leer. Por eso los parámetros se envían en el
    /// mismo orden en que están declarados en el procedimiento.
    /// </remarks>
    public class D_Conexion
    {
        /// <summary>Cadena de conexión a la base de datos productosdb.</summary>
        public static string cadenaConexion =
            "Server=localhost;Port=3306;Database=productosdb;Uid=usr_login;Pwd=Login2026*;CheckParameters=false;";
    }
}
