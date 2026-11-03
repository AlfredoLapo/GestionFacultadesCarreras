# Sistema de Gestión de Facultades y Carreras

## Grupo 2 - Relaciones entre Entidades

### Descripción del proyecto

Aplicación web desarrollada con ASP.NET Core MVC (.NET 10), Entity Framework Core y SQL Server para administrar facultades y carreras universitarias.

El sistema permite realizar operaciones CRUD (crear, consultar, editar y eliminar) y establece una relación de uno a muchos entre las entidades Facultad y Carrera.

Una facultad puede tener varias carreras, mientras que cada carrera pertenece a una facultad.

## Integrantes y aportes

### 1. Alfredo Lapo - Configuración inicial
- Creación del repositorio en GitHub.
- Configuración del proyecto ASP.NET Core MVC.
- Implementación inicial de la entidad Carrera.
- Generación del controlador y vistas mediante scaffolding.
- Configuración de SQL Server y migración inicial.

### 2. Nathaly Castillo - Validaciones
- Implementación de DataAnnotations en la entidad Carrera.
- Configuración de validaciones Required, StringLength, Range y Display.
- Personalización de mensajes de validación en español.
- Aplicación de migraciones correspondientes.

### 3. Robinson Romero - Entidad Facultad
- Creación del modelo Facultad.
- Implementación de propiedades obligatorias y opcionales.
- Configuración de DbContext.
- Generación del controlador y vistas CRUD de Facultades.

### 4. Daniel Quilca - Relación uno a muchos
- Implementación de la clave foránea FacultadId en Carrera.
- Configuración de la propiedad de navegación Facultad.
- Creación y aplicación de la migración relacional.
- Regeneración del controlador y vistas de Carreras.

### 5. Nancy Defaz - Componente autónomo y documentación
- Implementación de listas desplegables dinámicas de facultades en Create y Edit.
- Eliminación de campos duplicados generados por scaffolding.
- Modificación de Index y Details para mostrar el nombre de la facultad.
- Actualización del archivo README.md.
- Realización del commit y push final a GitHub.

## Tecnologías utilizadas

- ASP.NET Core MVC (.NET 10)
- C#
- Entity Framework Core
- SQL Server
- Visual Studio
- Git y GitHub
- HTML y Bootstrap

## Pasos para ejecutar la aplicación

1. Clonar el repositorio desde GitHub.
2. Abrir la solución GestionFacultadesCarreras.slnx en Visual Studio.
3. Verificar que estén instalados .NET 10 y SQL Server Express.
4. Configurar la cadena de conexión en appsettings.json para la instancia local de SQL Server.
5. Abrir la consola del Administrador de paquetes NuGet.
6. Ejecutar el comando `Update-Database` para aplicar las migraciones pendientes.
7. Compilar y ejecutar el proyecto desde Visual Studio.
8. Acceder a las rutas /Facultades y /Carreras para comprobar las operaciones CRUD.

## Relación entre entidades

La relación implementada es de uno a muchos (1:N).

- Una Facultad puede contener varias Carreras.
- Cada Carrera tiene una clave foránea FacultadId.
- La propiedad de navegación permite consultar la facultad asociada a cada carrera.

## Repositorio

https://github.com/AlfredoLapo/GestionFacultadesCarreras