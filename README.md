# Sistema de Gestión de Gimnasio

Aplicación de escritorio para administrar las operaciones de un gimnasio: clientes, membresías, asistencia, pagos, ventas, inventario, compras, clases, usuarios y reportes.

Está desarrollada en C# con Windows Forms, .NET Framework 4.7.2 y SQL Server. El código está organizado en una arquitectura de tres capas:

- `CapaEntidades`: modelos utilizados por el sistema.
- `CapaDatos`: consultas y operaciones sobre SQL Server.
- `CapaNegocio`: validaciones y reglas de negocio.
- `ProyectoFinal_Programacion3`: interfaz de usuario WinForms.
- `Pruebas`: pruebas y verificaciones de los módulos.

## Funcionalidades

- Inicio de sesión con roles y permisos.
- Registro, edición, consulta y desactivación de clientes.
- Asignación y renovación de membresías.
- Check-in diario y cobro de visitas.
- Pagos, abonos, cuentas por cobrar e historial.
- Punto de venta con inventario y ventas a crédito.
- Vista previa, impresión y exportación de facturas.
- Administración de productos, categorías, marcas y proveedores.
- Registro de compras y actualización de existencias.
- Gestión de entrenadores, horarios y clases.
- Panel principal con indicadores y reportes.
- Personalización del nombre, logo, datos fiscales e información de contacto del gimnasio.
- Correos de bienvenida mediante Resend al registrar clientes.

## Requisitos

- Windows 10 o posterior.
- Visual Studio con la carga de trabajo **Desarrollo de escritorio de .NET**.
- .NET Framework 4.7.2 Developer Pack.
- SQL Server LocalDB, Express o una instancia completa.

## Configuración de la base de datos

1. Abre SQL Server Management Studio o una herramienta equivalente.
2. Ejecuta [`ProyectoFinal_Programacion3/Base de Datos/queryDB.sql`](ProyectoFinal_Programacion3/Base%20de%20Datos/queryDB.sql). El script crea `GimnasioDB`, sus tablas y datos iniciales.
3. Si SQL Server no está en la instancia local predeterminada, actualiza `GimnasioDB` en [`ProyectoFinal_Programacion3/App.config`](ProyectoFinal_Programacion3/App.config):

```xml
<add name="GimnasioDB"
     connectionString="Data Source=.;Initial Catalog=GimnasioDB;Integrated Security=True"
     providerName="System.Data.SqlClient" />
```

El modelo completo de tablas se encuentra en [`BaseDatos.md`](ProyectoFinal_Programacion3/Base%20de%20Datos/BaseDatos.md).

## Ejecución

1. Abre `ProyectoFinal_Programacion3.slnx` en Visual Studio.
2. Selecciona `ProyectoFinal_Programacion3` como proyecto de inicio.
3. Compila y ejecuta con `F5`.

El script incluye estas cuentas de demostración:

| Rol | Usuario | Contraseña |
|---|---|---|
| Administrador | `admin` | `Admin123` |
| Cajero | `cajero` | `Cajero123` |
| Recepción | `recepcion` | `Recepcion123` |

Estas credenciales son únicamente para desarrollo. Deben cambiarse antes de utilizar el sistema con información real.

## Correos de bienvenida con Resend

Cuando se registra un cliente nuevo, el sistema valida su dirección y envía un mensaje personalizado con el nombre y los datos configurados del gimnasio. Una falla del proveedor de correo no revierte el registro del cliente; se muestra un aviso con el detalle para poder corregirlo.

La credencial no se almacena en el repositorio. Configúrala en Windows desde PowerShell:

```powershell
setx RESEND_API_KEY "re_tu_api_key"
setx RESEND_FROM "Mi Gimnasio <bienvenida@tudominio.com>"
```

Cierra y vuelve a abrir Visual Studio después de ejecutar los comandos. Para enviar desde una dirección propia, el dominio de `RESEND_FROM` debe estar verificado en Resend. Si no se define esa variable, se utiliza temporalmente `onboarding@resend.dev`, sujeto a las restricciones de prueba de Resend.

Nunca agregues claves reales al código, `App.config`, commits o capturas de pantalla. Si una clave fue compartida accidentalmente, revócala y genera una nueva.

## Flujo general

1. El usuario inicia sesión y el menú se adapta a los permisos de su rol.
2. Recepción registra clientes, les asigna membresías y controla sus entradas.
3. Caja procesa pagos, visitas, ventas de productos y créditos.
4. Los mantenimientos administran inventario, planes, personal y configuración.
5. Las ventas pueden consultarse y volver a imprimirse desde su historial.

Para una guía visual paso a paso consulta [`Manual de usuario/Manual de usuario.html`](Manual%20de%20usuario/Manual%20de%20usuario.html).

## Compilación desde consola

En una consola de desarrollador de Visual Studio:

```powershell
msbuild ProyectoFinal_Programacion3.slnx /t:Build /p:Configuration=Debug /m
```

Los ejecutables se generan dentro de las carpetas `bin/Debug` de cada proyecto.
