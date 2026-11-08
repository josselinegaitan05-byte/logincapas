using System;
using Datos;
using Entidades;
using Negocio.Contratos;

namespace Negocio
{
    /// <summary>
    /// Capa de Negocio (Modelo del MVP): reglas para iniciar sesión y registrar usuarios.
    /// Recibe sus dependencias por constructor (inyección de dependencias), por eso
    /// trabaja con los contratos y no con clases concretas.
    /// </summary>
    public class N_Usuario
    {
        /// <summary>Nombres de campo que usa la vista para marcar errores.</summary>
        public const string CampoUsuario = "usuario";
        /// <summary>Campo contraseña.</summary>
        public const string CampoPassword = "password";
        /// <summary>Campo confirmación de contraseña.</summary>
        public const string CampoConfirmacion = "confirmacion";
        /// <summary>Campo código.</summary>
        public const string CampoCodigo = "codigo";

        /// <summary>Longitud mínima de una contraseña nueva.</summary>
        public const int LongitudMinimaPassword = 6;

        private readonly IUsuarioRepositorio _repositorio;
        private readonly IHashService _hashService;
        private readonly IVerificarHashService _verificarHashService;

        /// <summary>Crea el servicio con su repositorio y los dos contratos de hash.</summary>
        public N_Usuario(IUsuarioRepositorio repositorio,
                         IHashService hashService,
                         IVerificarHashService verificarHashService)
        {
            _repositorio = repositorio ?? throw new ArgumentNullException(nameof(repositorio));
            _hashService = hashService ?? throw new ArgumentNullException(nameof(hashService));
            _verificarHashService = verificarHashService ?? throw new ArgumentNullException(nameof(verificarHashService));
        }

        /// <summary>
        /// Valida las credenciales. Usa <see cref="IVerificarHashService"/> para comparar la
        /// contraseña escrita con el hash guardado.
        /// </summary>
        public ResultadoOperacion IniciarSesion(string strUsuario, string strPassword)
        {
            strUsuario = (strUsuario ?? "").Trim();

            if (strUsuario == "")
                return ResultadoOperacion.Error("Ingrese el nombre de usuario.", CampoUsuario);
            if (string.IsNullOrEmpty(strPassword))
                return ResultadoOperacion.Error("Ingrese la contraseña.", CampoPassword);

            E_Usuario usuario;
            try
            {
                usuario = _repositorio.ObtenerPorUsuario(strUsuario);
            }
            catch (Exception ex)
            {
                return ResultadoOperacion.Error("No se pudo conectar a la base de datos: " + ex.Message);
            }

            // Mismo mensaje si no existe o si la clave es incorrecta: no se revela qué usuarios existen
            if (usuario == null || !_verificarHashService.Verificar(strPassword, usuario.dsPassword))
                return ResultadoOperacion.Error("Usuario o contraseña incorrectos.", CampoPassword);

            if (!usuario.EstaActivo)
                return ResultadoOperacion.Error("El usuario está inactivo. Contacte al administrador.", CampoUsuario);

            return ResultadoOperacion.Ok("¡Bienvenido, " + usuario.dsUsuario + "!", usuario);
        }

        /// <summary>
        /// Registra un usuario nuevo. Usa <see cref="IHashService"/> para generar el hash
        /// antes de mandar el usuario a la capa de Datos.
        /// </summary>
        public ResultadoOperacion Registrar(string dsId, string dsUsuario, string password,
                                            string confirmacion, string creadoPor)
        {
            dsId = (dsId ?? "").Trim();
            dsUsuario = (dsUsuario ?? "").Trim();

            if (dsId == "")
                return ResultadoOperacion.Error("Ingrese el código del usuario.", CampoCodigo);
            if (dsUsuario == "")
                return ResultadoOperacion.Error("Ingrese el nombre de usuario.", CampoUsuario);
            if (dsUsuario.Length > 50 || dsUsuario.Contains(" "))
                return ResultadoOperacion.Error("El usuario no puede tener espacios ni más de 50 caracteres.", CampoUsuario);
            if (string.IsNullOrEmpty(password) || password.Length < LongitudMinimaPassword)
                return ResultadoOperacion.Error("La contraseña debe tener al menos " + LongitudMinimaPassword + " caracteres.", CampoPassword);
            if (password != confirmacion)
                return ResultadoOperacion.Error("Las contraseñas no coinciden.", CampoConfirmacion);

            try
            {
                if (_repositorio.ObtenerPorUsuario(dsUsuario) != null)
                    return ResultadoOperacion.Error("Ya existe un usuario llamado '" + dsUsuario + "'.", CampoUsuario);

                E_Usuario nuevo = new E_Usuario
                {
                    dsId = dsId,
                    dsUsuario = dsUsuario,
                    dsPassword = _hashService.GenerarHash(password), // solo viaja el hash
                    dsEstado = '1',
                    dsUsuarioCreacion = string.IsNullOrEmpty(creadoPor) ? "Sistema" : creadoPor,
                    dtFechaCreacion = DateTime.Now
                };
                nuevo.id = _repositorio.Insertar(nuevo);
                return ResultadoOperacion.Ok("Usuario '" + dsUsuario + "' registrado correctamente.", nuevo);
            }
            catch (Exception ex)
            {
                return ResultadoOperacion.Error("No se pudo guardar el usuario: " + ex.Message);
            }
        }
    }
}
