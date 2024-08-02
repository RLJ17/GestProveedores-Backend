# Gestión de Proveedores - Backend

Desarrollo de aplicación web para Debida Diligencia de Proveedores y
Cruce con Listas de Alto Riesgo.

Este proyecto es una aplicación ASP.NET Core para gestionar proveedores. A continuación, se describen los pasos para configurar y ejecutar la aplicación localmente.


## Requisitos Previos

- .NET Core SDK 6.0 o superior
- SQL Server (Express o cualquier edición)
- Visual Studio o Visual Studio Code

## Configuración del Proyecto

### 1. Clonar el Repositorio

Clona el repositorio del proyecto en tu máquina local usando el siguiente comando:

```bash
git clone <URL-del-repositorio>
```

### 2. Abrir el Proyecto
Abre el proyecto en tu editor (Visual Studio Code o Visual Studio - Recomendado).

### 3. Configurar la Cadena de Conexión

Abre el archivo `appsettings.json` y localiza la sección `"ConnectionStrings"`. Actualiza el valor de `"DatabaseConnection"` para apuntar a tu servidor de base de datos SQL Server local. La cadena de conexión debe tener un formato similar al siguiente:

```json
{
  "ConnectionStrings": {
    "DatabaseConnection": "Server=MI_SERVIDOR\\SQLEXPRESS;Database=ProveedoresDatabase;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True"
  }
}
```
### 4. Instalar las Dependencias

Para instalar todas las dependencias necesarias del proyecto, puedes utilizar la Consola del Administrador de Paquetes en Visual Studio siguiendo estos pasos:

- Abre tu solución en Visual Studio.
- Ve al menú `Ver` y selecciona `Otras ventanas`. Luego haz clic en `Consola del Administrador de Paquetes`.
- En la consola que se abre en la parte inferior de Visual Studio, asegúrate de que el proyecto correcto esté seleccionado en el menú desplegable `Proyecto predeterminado`.
- Ejecuta el siguiente comando en la consola:

```powershell
Restore
```
### 5. Aplicar las Migraciones

Para aplicar las migraciones a la base de datos y crear el esquema necesario, puedes utilizar la Consola del Administrador de Paquetes en Visual Studio siguiendo estos pasos:


- Sigue los pasos anteriores para abrir la `Consola del Administrador de Paquetes`.
- Ejecuta el siguiente comando en la consola para aplicar las migraciones:

```powershell
Update-Database
```
### 6. Ejecutar la Aplicación

Para ejecutar la aplicación localmente, sigue estos pasos:

- Abre tu solución en Visual Studio.
- Ve al menú `Depurar` y selecciona `Iniciar sin depurar` o presiona `Ctrl+F5`.

## Usuarios de Prueba

La base de datos viene preconfigurada con los siguientes usuarios de prueba para facilitar el inicio de sesión y la evaluación de la aplicación:

* **Usuario:** admin  ----> **Contraseña:** admin123
* **Usuario:** user ----> **Contraseña:** user123
