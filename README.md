# Login de Usuario en Capas con Patrón MVP

Aplicación de escritorio en **C# Windows Forms** que valida usuarios contra **MySQL**, organizada en cuatro capas (Entidades, Datos, Negocio, Presentación) y con el **patrón de diseño MVP** (Modelo – Vista – Presentador). Las contraseñas se guardan como hash **SHA-512**; el hash se genera y se verifica en la capa de Negocio mediante dos contratos independientes.

| | |
|---|---|
| **Autor** | _(escribe aquí tu nombre completo)_ |
| **Fecha** | 8 de noviembre de 2026 |
| **Curso** | Herramientas de la Programación Aplicada III (.NET) — Grupo 1IL133 |
| **Instructora** | Ing. Irina Fong |
| **Universidad** | Universidad Tecnológica de Panamá — Facultad de Ingeniería en Sistemas |
| **Laboratorio** | Laboratorio de MVP — Nota de Parcial Práctico |

---

## Tabla de contenido

1. [Tecnologías y versiones](#1-tecnologías-y-versiones)
2. [Arquitectura: capas + MVP](#2-arquitectura-capas--mvp)
3. [Requisito 1: contratos de hash en Negocio](#3-requisito-1-contratos-de-hash-en-negocio)
4. [Conexión con privilegios mínimos](#4-conexión-con-privilegios-mínimos)
5. [Requisito 2: menú lateral, hora y sesión](#5-requisito-2-menú-lateral-hora-y-sesión)
6. [Imágenes de resultado](#6-imágenes-de-resultado)
7. [Controles utilizados](#7-controles-utilizados)
8. [Proceso de instalación](#8-proceso-de-instalación)
9. [Estructura del repositorio](#9-estructura-del-repositorio)
10. [Referencias](#10-referencias)

---

## 1. Tecnologías y versiones

| Tecnología | Versión | Uso |
|---|---|---|
| C# | 7.3 | Lenguaje de programación |
| .NET Framework | 4.8 | Plataforma de la aplicación |
| Windows Forms | .NET Framework 4.8 | Interfaz gráfica (formulario MDI) |
| Visual Studio Community | 2026 (versión 18) | IDE |
| MySQL Server | 8.0 o superior | Gestor de base de datos |
| MySQL Workbench | 8.0 | Ejecutar scripts y administrar la base |
| MySql.Data (NuGet) | 8.4.0 | Conector ADO.NET para MySQL |
| System.Security.Cryptography (SHA512) | .NET Framework 4.8 | Generar y verificar el hash |
| Segoe MDL2 Assets | Windows 10/11 | Íconos del menú lateral (sin archivos de imagen) |
| Sistema operativo | Windows 10/11 | Ejecución |

## 2. Arquitectura: capas + MVP

```
Presentacion (WinForms)  ──►  Negocio  ──►  Datos  ──►  MySQL (procedimientos almacenados)
   Vistas (interfaces)          N_Usuario       D_Usuario       sp_ObtenerUsuarioLogin
   Presentadores                N_Craps         D_Conexion      sp_InsertarUsuario
   Formularios                  Contratos/      IUsuarioRepositorio
                                Servicios/
            └──────────────── Entidades (E_Usuario) ────────────────┘
```

| Proyecto | Responsabilidad | Referencias |
|---|---|---|
| **Entidades** | Clase `E_Usuario` (solo datos) | — |
| **Datos** | `D_Conexion`, `D_Usuario` e `IUsuarioRepositorio`; solo llama procedimientos almacenados | Entidades, MySql.Data |
| **Negocio** | Reglas: login, registro, sesión, juego de Craps y los contratos de hash | Entidades, Datos |
| **Presentacion** | Vistas, Presentadores y formularios Windows Forms | Entidades, Negocio, Datos (solo en `Contenedor.cs`) |

### Patrón MVP

| Rol | Dónde está | Qué hace |
|---|---|---|
| **Modelo** | `Negocio` (`N_Usuario`, `N_Craps`, `SesionActual`) + `Datos` | Datos y reglas de negocio |
| **Vista** | `Presentacion/Vistas/I*View.cs` implementadas por `Presentacion/Formularios/frm*.cs` | Solo muestra controles y avisa al presentador con eventos. No sabe qué es un hash ni toca la base de datos |
| **Presentador** | `Presentacion/Presentadores/*Presenter.cs` | Recibe la acción de la vista, llama al modelo y le dice a la vista qué mostrar |

Ejemplo del flujo de login:

1. `frmLogin` (Vista) dispara el evento `IniciarSesionSolicitado`.
2. `LoginPresenter` lee `vista.Usuario` y `vista.Password` y llama a `N_Usuario.IniciarSesion()`.
3. `N_Usuario` obtiene el usuario con `IUsuarioRepositorio` y compara la contraseña con `IVerificarHashService.Verificar()`.
4. El presentador llama a `vista.MostrarError(...)` o a `vista.AbrirMenuPrincipal()`.

Todas las dependencias se crean en un solo lugar, `Presentacion/Contenedor.cs` (raíz de composición); los presentadores y `N_Usuario` reciben interfaces por su constructor.

## 3. Requisito 1: contratos de hash en Negocio

Dos contratos independientes en `Negocio/Contratos`, cada uno con una sola responsabilidad:

```csharp
// Negocio/Contratos/IHashService.cs — solo GENERA el hash (registro / cambio de clave)
public interface IHashService
{
    string GenerarHash(string textoPlano);
}

// Negocio/Contratos/IVerificarHashService.cs — solo VERIFICA (inicio de sesión)
public interface IVerificarHashService
{
    bool Verificar(string textoPlano, string hashAlmacenado);
}
```

La implementación es `Negocio/Servicios/Sha512PasswordService.cs`, que cumple ambos contratos con SHA-512 y compara en tiempo constante. Produce los mismos 64 bytes que `UNHEX(SHA2(texto, 512))` en MySQL, así que los usuarios creados por script y los creados desde la aplicación son compatibles. Para pasar a BCrypt o Argon2 solo se cambia esta clase; la Vista, el Presentador y la base de datos no se tocan.

| Dónde se usa | Contrato |
|---|---|
| `N_Usuario.Registrar()` (formulario *Registrar usuario*) | `IHashService.GenerarHash()` |
| `N_Usuario.IniciarSesion()` (formulario *Login*) | `IVerificarHashService.Verificar()` |

## 4. Conexión con privilegios mínimos

La aplicación **no** se conecta como `root`. El script `BaseDatos/02_usuario_acceso_bd.sql` crea el usuario `usr_login`, que **solo** puede ejecutar los dos procedimientos de la aplicación:

```sql
CREATE USER 'usr_login'@'localhost' IDENTIFIED BY 'Login2026*';
GRANT EXECUTE ON PROCEDURE productosdb.sp_ObtenerUsuarioLogin TO 'usr_login'@'localhost';
GRANT EXECUTE ON PROCEDURE productosdb.sp_InsertarUsuario     TO 'usr_login'@'localhost';
```

Con ese usuario un `SELECT * FROM usuarios` devuelve *ERROR 1142* (sin permiso). La cadena de conexión está en `Datos/D_Conexion.cs`:

```
Server=localhost;Port=3306;Database=productosdb;Uid=usr_login;Pwd=Login2026*;CheckParameters=false;
```

`CheckParameters=false` es necesario porque un usuario con solo `EXECUTE` no puede leer los metadatos del procedimiento que el conector consulta por defecto.

## 5. Requisito 2: menú lateral, hora y sesión

`frmPrincipal` es un formulario **MDI** (`IsMdiContainer = true`):

- **Menú lateral izquierdo** (`pnlMenu`): *Inicio*, *Registrar usuario* y *Juego de Craps*. Cada opción abre un formulario hijo dentro del área MDI.
- **Hora actual** en la barra superior (`lblHora` y `lblFecha`), actualizada cada segundo por un `Timer` a través de `PrincipalPresenter.ActualizarHora()`.
- **Sesión del usuario en la parte inferior del menú** (`pnlSesion`): avatar con iniciales, nombre de usuario, código, hora de inicio de sesión y botón *Cerrar sesión*.

## 6. Imágenes de resultado

> Capturas tomadas de la aplicación en ejecución el 8 de noviembre de 2026.

### Resultado de MDI

Formulario principal MDI con el **menú lateral** a la izquierda, la **hora actual** arriba a la derecha y la **sesión del usuario** (avatar, nombre, código y hora de entrada) en la parte inferior del menú:

![Formulario MDI con menú lateral, hora y sesión](docs/img/05-mdi-inicio.png)

Formulario hijo *Registrar usuario* dentro del MDI. La contraseña se convierte en hash con `IHashService.GenerarHash()` y a la base de datos solo llega el hash. El mensaje confirma que el usuario `jperez` se guardó:

![Registro de usuario exitoso](docs/img/07-registro-exitoso.png)

### Resultado del juego de Craps

**Partida ganada:** el punto fue 4 y volvió a salir antes que un 7.

![Craps: partida ganada](docs/img/08-craps-gana.png)

**Partida perdida:** el punto fue 5 y salió un 7 antes de repetirlo.

![Craps: partida perdida](docs/img/09-craps-pierde.png)

### Resultado de validaciones

Pantalla de login:

![Login](docs/img/01-login.png)

| Validación | Imagen |
|---|---|
| **Campo usuario vacío** (`ErrorProvider` junto al campo y mensaje en rojo) | ![Campos vacíos](docs/img/02-validacion-campos-vacios.png) |
| **Contraseña incorrecta**, verificada con `IVerificarHashService` | ![Contraseña incorrecta](docs/img/03-validacion-clave-incorrecta.png) |
| **Usuario inactivo** (`dsEstado = '0'`): la contraseña es correcta, pero no se permite entrar | ![Usuario inactivo](docs/img/04-validacion-usuario-inactivo.png) |
| **Registro: las contraseñas no coinciden** | ![Validación de registro](docs/img/06-validacion-registro.png) |

Reglas validadas en `N_Usuario`:

| Formulario | Validación | Mensaje |
|---|---|---|
| Login | Usuario vacío | "Ingrese el nombre de usuario." |
| Login | Contraseña vacía | "Ingrese la contraseña." |
| Login | Usuario no existe o hash no coincide | "Usuario o contraseña incorrectos." |
| Login | `dsEstado = '0'` | "El usuario está inactivo. Contacte al administrador." |
| Login / Registro | MySQL apagado o sin permiso | "No se pudo conectar a la base de datos: …" |
| Registro | Código o usuario vacío | "Ingrese el código del usuario." / "Ingrese el nombre de usuario." |
| Registro | Usuario con espacios o más de 50 caracteres | "El usuario no puede tener espacios ni más de 50 caracteres." |
| Registro | Contraseña con menos de 6 caracteres | "La contraseña debe tener al menos 6 caracteres." |
| Registro | Confirmación distinta | "Las contraseñas no coinciden." |
| Registro | Usuario repetido | "Ya existe un usuario llamado '…'." |

## 7. Controles utilizados

| Control | Formulario(s) | Para qué se usa |
|---|---|---|
| `Form` (MDI, `IsMdiContainer`) | frmPrincipal | Contenedor de los formularios hijos |
| `Form` (hijo MDI) | frmInicio, frmRegistroUsuario, frmCraps | Pantallas que se abren desde el menú |
| `Panel` | Todos | Menú lateral, barra superior, panel de sesión, tarjetas |
| `Button` (`FlatStyle.Flat`) | Todos | Opciones del menú, Ingresar, Guardar, Lanzar dados, Cerrar sesión |
| `Label` | Todos | Títulos, hora, fecha, usuario en sesión, mensajes de validación |
| `TextBox` (`UseSystemPasswordChar`) | frmLogin, frmRegistroUsuario | Usuario y contraseña ocultos |
| `CheckBox` | frmLogin | Mostrar u ocultar la contraseña |
| `ErrorProvider` | frmLogin, frmRegistroUsuario | Ícono de error junto al campo inválido |
| `Timer` | frmPrincipal | Actualizar la hora cada 1000 ms |
| `MessageBox` | frmPrincipal | Confirmar el cierre de sesión |
| `DadoControl` (personalizado) | frmCraps | Dibuja cada dado con GDI+ |
| `AvatarControl` (personalizado) | frmPrincipal | Círculo con las iniciales del usuario en sesión |

Controles en el diseñador de Visual Studio:

| `frmPrincipal` (MDI) | `frmLogin` |
|---|---|
| ![Controles de frmPrincipal](docs/img/12-controles-frmprincipal.png) | ![Controles de frmLogin](docs/img/13-controles-frmlogin.png) |

## 8. Proceso de instalación

**Requisitos previos:** Windows 10/11, Visual Studio 2022 o 2026 con la carga de trabajo *Desarrollo de escritorio de .NET*, MySQL Server 8 y MySQL Workbench.

1. **Clonar o descargar el repositorio.**

   ```bash
   git clone <url-del-repositorio>
   ```

2. **Crear la base de datos.** En MySQL Workbench, conectado como `root`, abrir y ejecutar (rayo normal) en este orden:
   1. `BaseDatos/01_script_productosdb.sql`: base `productosdb`, tabla `usuarios` (InnoDB), usuarios de prueba y procedimientos almacenados.
   2. `BaseDatos/02_usuario_acceso_bd.sql`: usuario `usr_login` con privilegios mínimos.
3. **Abrir la solución** `LoginCapas/LoginCapas.slnx` en Visual Studio.
4. **Compilar** con `Ctrl + Shift + B`. El paquete NuGet `MySql.Data` se restaura solo.
5. **Ejecutar:** clic derecho en el proyecto `Presentacion` → *Establecer como proyecto de inicio* → `F5`.
6. **Iniciar sesión** con un usuario de prueba:

| Usuario | Contraseña | Resultado |
|---|---|---|
| `admin` | `123456` | Entra al menú principal |
| `root` | `251427` | Entra al menú principal |
| `inactivo` | `123456` | Rechazado: usuario inactivo |

Si MySQL usa otro puerto o contraseña, cambie la cadena en `LoginCapas/Datos/D_Conexion.cs`.

**Respaldo de la base de datos:** en MySQL Workbench, *Server → Data Export*, marcar `productosdb`, activar *Dump Stored Procedures and Functions* e *Include Create Schema*. Se restaura con *Server → Data Import*.

### Capturas del proceso de instalación

| Scripts ejecutados en MySQL Workbench | Solución abierta en Visual Studio |
|---|---|
| ![Scripts en Workbench](docs/img/10-instalacion-workbench.png) | ![Solución en Visual Studio](docs/img/11-instalacion-solucion.png) |

### Solución de problemas

| Mensaje | Causa y solución |
|---|---|
| *"Un proyecto con un tipo de salida de biblioteca de clases no se puede iniciar directamente"* | Se intentó ejecutar una capa (Datos, Negocio o Entidades). Clic derecho en **Presentacion** → *Establecer como proyecto de inicio*. |
| *"No se pudo conectar a la base de datos"* | MySQL está apagado, o no se ejecutó `02_usuario_acceso_bd.sql`, o la cadena de `D_Conexion.cs` no coincide con el puerto/contraseña. |
| `FileLoadException … Una directiva de Control de aplicaciones bloqueó este archivo (0x800711C7)` | Windows (Smart App Control) bloquea los `.dll` sin firma. Mover el proyecto a una carpeta local (por ejemplo `C:\Proyectos`), ejecutar `Get-ChildItem . -Recurse \| Unblock-File`, borrar `bin` y `obj` y recompilar. Si persiste, desactivar Smart App Control en *Seguridad de Windows → Control de aplicaciones y navegador*. |

## 9. Estructura del repositorio

```
├── README.md
├── .gitignore
├── BaseDatos/
│   ├── 01_script_productosdb.sql      tabla, datos de prueba y procedimientos
│   └── 02_usuario_acceso_bd.sql       usuario usr_login (privilegios mínimos)
├── docs/img/                          capturas usadas en este README
└── LoginCapas/
    ├── LoginCapas.slnx
    ├── Entidades/   E_Usuario.cs
    ├── Datos/       D_Conexion.cs, D_Usuario.cs, IUsuarioRepositorio.cs
    ├── Negocio/
    │   ├── Contratos/   IHashService.cs, IVerificarHashService.cs
    │   ├── Servicios/   Sha512PasswordService.cs
    │   └── N_Usuario.cs, N_Craps.cs, SesionActual.cs, ResultadoOperacion.cs
    └── Presentacion/
        ├── Vistas/         ILoginView, IPrincipalView, IInicioView, IRegistroUsuarioView, ICrapsView
        ├── Presentadores/  LoginPresenter, PrincipalPresenter, InicioPresenter, RegistroUsuarioPresenter, CrapsPresenter
        ├── Formularios/    frmLogin, frmPrincipal (MDI), frmInicio, frmRegistroUsuario, frmCraps
        ├── Controles/      DadoControl, AvatarControl, Iconos
        ├── Contenedor.cs   raíz de composición
        ├── Tema.cs         colores
        └── Program.cs
```

**Documentación del código:** todas las clases y miembros públicos tienen comentarios XML (`/// <summary>`), y los proyectos generan el archivo de documentación (`GenerateDocumentationFile`).

## 10. Referencias

- Fong, I. *Laboratorio de Capas Parte I*. https://youtu.be/ig4llLQ3tFw
- Fong, I. *Crear Usuarios para acceso a la Base de Datos*. https://youtu.be/WJMZ3KzXmlc
- Fong, I. *MySQL WorkBench*. https://youtu.be/0QHUkFLb3rA
- Ballesteros, C. *Importar y Exportar una Base de datos en MySQL Workbench*. https://youtu.be/jTs1nSwAcRM
- RJ Code Advance ES. *Formulario Plano Moderno, Menú animado* (referencia del menú lateral). https://www.youtube.com/watch?v=y1jftnTaTXU
- Material del curso: *Lb de Capas*, *Rúbrica de Capas (Parcial Práctico)*, *Índices en MySQL*, *Todo o Nada*, *Restricciones de Claves Externas*, *Procedimientos Almacenados*.
