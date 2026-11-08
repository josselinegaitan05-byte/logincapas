using System;
using System.Security.Cryptography;
using System.Text;
using Negocio.Contratos;

namespace Negocio.Servicios
{
    /// <summary>
    /// Implementación real de los dos contratos usando SHA-512.
    /// </summary>
    /// <remarks>
    /// Produce los mismos 64 bytes que <c>UNHEX(SHA2(texto, 512))</c> en MySQL, por eso los
    /// usuarios creados desde el script SQL y los creados desde la aplicación son compatibles.
    /// Si mañana se cambia a BCrypt o Argon2, solo se cambia esta clase: la Vista, el
    /// Presentador y la base de datos no se tocan.
    /// </remarks>
    public class Sha512PasswordService : IHashService, IVerificarHashService
    {
        /// <inheritdoc />
        public string GenerarHash(string textoPlano)
        {
            if (textoPlano == null)
                throw new ArgumentNullException(nameof(textoPlano));

            using (SHA512 sha = SHA512.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                return ConvertirAHex(bytes); // 128 caracteres hexadecimales
            }
        }

        /// <inheritdoc />
        public bool Verificar(string textoPlano, string hashAlmacenado)
        {
            if (textoPlano == null || string.IsNullOrEmpty(hashAlmacenado))
                return false;

            string hashCalculado = GenerarHash(textoPlano);
            return CompararTiempoConstante(hashCalculado, hashAlmacenado.ToUpperInvariant());
        }

        /// <summary>Convierte bytes a texto hexadecimal en mayúsculas (igual que HEX() de MySQL).</summary>
        private static string ConvertirAHex(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        /// <summary>
        /// Compara dos cadenas recorriéndolas completas, para que el tiempo de respuesta
        /// no revele cuántos caracteres coincidieron (evita ataques de tiempo).
        /// </summary>
        private static bool CompararTiempoConstante(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            int diferencia = 0;
            for (int i = 0; i < a.Length; i++)
                diferencia |= a[i] ^ b[i];
            return diferencia == 0;
        }
    }
}
