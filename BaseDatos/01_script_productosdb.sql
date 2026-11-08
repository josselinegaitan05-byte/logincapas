-- =====================================================================
--  Laboratorio MVP: Login de Usuario - Programación en Capas
-- =====================================================================

-- 1. Base de datos ------------------------------------------------------
CREATE DATABASE IF NOT EXISTS productosdb
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE productosdb;

-- 2. Tabla de usuarios --------------------------------------------------
--    ENGINE = InnoDB: soporta transacciones (ACID) y claves foráneas.
--    dsPassword VARBINARY(64): hash SHA-512 en bytes (512 bits = 64 bytes).
DROP TABLE IF EXISTS usuarios;

CREATE TABLE usuarios (
  id                    INT           NOT NULL AUTO_INCREMENT,
  dsId                  VARCHAR(50)   NOT NULL,
  dsUsuario             VARCHAR(50)   NOT NULL,
  dsPassword            VARBINARY(64) NOT NULL,
  dsEstado              CHAR(1)       NOT NULL DEFAULT '1',
  dsUsuarioCreacion     VARCHAR(50)   NOT NULL,
  dtFechaCreacion       DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
  dsUsuarioModificacion VARCHAR(50)   NOT NULL DEFAULT 'Sistema',
  dtFechaModificacion   DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP
                                      ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (id),
  -- Índice UNIQUE: no se repiten nombres de usuario y acelera la búsqueda
  -- del login (WHERE dsUsuario = ...) usando un árbol B-Tree.
  UNIQUE KEY uq_usuarios_dsUsuario (dsUsuario)
) ENGINE = InnoDB;

-- 3. Usuarios de prueba -------------------------------------------------
--    UNHEX(SHA2(texto, 512)) produce exactamente los mismos 64 bytes que
--    Sha512PasswordService.GenerarHash() en C#, así que ambos son compatibles.
INSERT INTO usuarios (dsId, dsUsuario, dsPassword, dsEstado, dsUsuarioCreacion)
VALUES ('001', 'admin',    UNHEX(SHA2('123456', 512)), '1', 'Sistema'),
       ('002', 'root',     UNHEX(SHA2('251427', 512)), '1', 'Sistema'),
       ('003', 'inactivo', UNHEX(SHA2('123456', 512)), '0', 'Sistema');

-- 4. Procedimiento: obtener el usuario para el login ----------------------
--    Devuelve el hash en hexadecimal (texto) para que la capa de Negocio
--    lo compare con IVerificarHashService.Verificar(textoPlano, hash).
DROP PROCEDURE IF EXISTS sp_ObtenerUsuarioLogin;

DELIMITER //
CREATE PROCEDURE sp_ObtenerUsuarioLogin (
    IN _dsUsuario VARCHAR(50)
)
BEGIN
    SELECT id,
           dsId,
           dsUsuario,
           HEX(dsPassword) AS dsPassword,
           dsEstado,
           dsUsuarioCreacion,
           dtFechaCreacion
    FROM usuarios
    WHERE dsUsuario = _dsUsuario;
END //
DELIMITER ;

-- 5. Procedimiento: registrar un usuario --------------------------------
--    Recibe el hash ya generado por IHashService.GenerarHash() (hexadecimal)
--    y lo guarda en bytes con UNHEX. Devuelve el id generado.
DROP PROCEDURE IF EXISTS sp_InsertarUsuario;

DELIMITER //
CREATE PROCEDURE sp_InsertarUsuario (
    IN _dsId              VARCHAR(50),
    IN _dsUsuario         VARCHAR(50),
    IN _dsPasswordHash    CHAR(128),
    IN _dsUsuarioCreacion VARCHAR(50)
)
BEGIN
    INSERT INTO usuarios (dsId, dsUsuario, dsPassword, dsEstado, dsUsuarioCreacion)
    VALUES (_dsId, _dsUsuario, UNHEX(_dsPasswordHash), '1', _dsUsuarioCreacion);

    SELECT LAST_INSERT_ID() AS id;
END //
DELIMITER ;

-- 6. Pruebas ------------------------------------------------------------
CALL sp_ObtenerUsuarioLogin('admin');      -- 1 fila, hash en hexadecimal
CALL sp_ObtenerUsuarioLogin('noexiste');   -- 0 filas

SELECT id, dsUsuario, HEX(dsPassword) AS hash_sha512, dsEstado FROM usuarios;
