using Datos;
using Negocio;
using Negocio.Servicios;

namespace Presentacion
{
    /// <summary>
    /// Raíz de composición: el único lugar donde se eligen las clases concretas.
    /// Los presentadores reciben contratos (interfaces), nunca crean sus dependencias.
    /// </summary>
    public static class Contenedor
    {
        private static readonly Sha512PasswordService _passwordService = new Sha512PasswordService();

        /// <summary>
        /// Repositorio de usuarios. Por defecto el de MySQL; se puede reemplazar
        /// (por ejemplo por uno en memoria) para pruebas.
        /// </summary>
        public static IUsuarioRepositorio Repositorio { get; set; } = new D_Usuario();

        /// <summary>Crea el servicio de usuarios con el repositorio y los dos contratos de hash.</summary>
        public static N_Usuario CrearServicioUsuario()
        {
            // La misma clase cumple los dos contratos, pero N_Usuario los recibe por separado
            return new N_Usuario(Repositorio, _passwordService, _passwordService);
        }
    }
}
