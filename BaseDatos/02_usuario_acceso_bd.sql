-- =====================================================================
--  Conexión específica con PRIVILEGIOS MÍNIMOS para la aplicación.
--  La aplicación no usa root: usa 'usr_login', que solo puede EJECUTAR
--  los dos procedimientos que necesita. No puede hacer SELECT, INSERT,
--  UPDATE ni DELETE directo sobre la tabla usuarios.
--  Ejecutar conectado como root en MySQL Workbench.
-- =====================================================================

-- 1. Crear el usuario (solo puede conectarse desde la misma máquina)
DROP USER IF EXISTS 'usr_login'@'localhost';
CREATE USER 'usr_login'@'localhost' IDENTIFIED BY 'Login2026*';

-- 2. Permisos mínimos: solo EXECUTE sobre los procedimientos de la app
GRANT EXECUTE ON PROCEDURE productosdb.sp_ObtenerUsuarioLogin
  TO 'usr_login'@'localhost';
GRANT EXECUTE ON PROCEDURE productosdb.sp_InsertarUsuario
  TO 'usr_login'@'localhost';

FLUSH PRIVILEGES;

-- 3. Verificar los permisos
SHOW GRANTS FOR 'usr_login'@'localhost';

-- 4. Prueba (opcional): conéctate en Workbench como usr_login y ejecuta
--      SELECT * FROM productosdb.usuarios;          -> ERROR 1142 (sin permiso)
--      CALL productosdb.sp_ObtenerUsuarioLogin('admin');  -> funciona
--
-- Cadena de conexión que usa la aplicación (Datos/D_Conexion.cs):
-- Server=localhost;Port=3306;Database=productosdb;Uid=usr_login;Pwd=Login2026*;CheckParameters=false;
