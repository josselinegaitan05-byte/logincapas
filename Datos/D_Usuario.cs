using System;
using System.Data;
using Entidades;
using MySql.Data.MySqlClient;

namespace Datos
{
    /// <summary>
    /// Capa de Datos: única clase que habla con MySQL para la tabla usuarios.
    /// Solo llama a procedimientos almacenados (nunca arma SQL con texto del usuario).
    /// </summary>
    public class D_Usuario : D_Conexion, IUsuarioRepositorio
    {
        /// <inheritdoc />
        public E_Usuario ObtenerPorUsuario(string dsUsuario)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_ObtenerUsuarioLogin", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Nombre igual al parámetro del SP (con guion bajo, sin @)
                    cmd.Parameters.AddWithValue("_dsUsuario", dsUsuario);

                    using (MySqlDataReader fReader = cmd.ExecuteReader())
                    {
                        if (!fReader.Read())
                            return null; // el usuario no existe

                        return new E_Usuario
                        {
                            // GetInt32: la columna id es entera y NOT NULL
                            id = fReader.GetInt32("id"),
                            dsId = fReader.GetString("dsId"),
                            dsUsuario = fReader.GetString("dsUsuario"),
                            dsPassword = fReader.GetString("dsPassword"), // hash en hexadecimal
                            dsEstado = fReader.GetString("dsEstado")[0],
                            dsUsuarioCreacion = fReader.GetString("dsUsuarioCreacion"),
                            dtFechaCreacion = fReader.GetDateTime("dtFechaCreacion")
                        };
                    }
                }
            }
        }

        /// <inheritdoc />
        public int Insertar(E_Usuario usuario)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_InsertarUsuario", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Mismo orden que en el procedimiento (CheckParameters=false)
                    cmd.Parameters.AddWithValue("_dsId", usuario.dsId);
                    cmd.Parameters.AddWithValue("_dsUsuario", usuario.dsUsuario);
                    cmd.Parameters.AddWithValue("_dsPasswordHash", usuario.dsPassword);
                    cmd.Parameters.AddWithValue("_dsUsuarioCreacion", usuario.dsUsuarioCreacion);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
