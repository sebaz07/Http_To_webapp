# Documentación del Ejercicio: MyAPI2

## Descripción General
Este proyecto es una API mínima desarrollada con ASP.NET Core. Expone varios endpoints HTTP básicos para demostrar el manejo de rutas y métodos HTTP en una aplicación web sencilla.

## Estructura del Proyecto
- `Program.cs`: Archivo principal donde se configuran y definen los endpoints de la API.
- `appsettings.json` y `appsettings.Development.json`: Archivos de configuración de la aplicación.
- `MyAPI2.csproj`: Archivo de proyecto de .NET.
- `Properties/launchSettings.json`: Configuración de perfiles de lanzamiento.

## Endpoints Definidos
En el archivo `Program.cs` se definen los siguientes endpoints:

| Método  | Ruta   | Respuesta             | Descripción                |
|---------|--------|-----------------------|----------------------------|
| GET     | `/`    | "Root Page!"          | Página raíz                |
| GET     | `/about` | "About Page!"        | Página de información      |
| PUT     | `/`    | "This is a put"       | Ejemplo de método PUT      |
| DELETE  | `/`    | "This is an Delete"   | Ejemplo de método DELETE   |

## Código Principal (`Program.cs`)
```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Root Page!");
app.MapGet("/about", () => "About Page!");
app.MapPut("/", () => "This is a put");
app.MapDelete("/", () => "This is an Delete");

app.Run();
```

## Cómo Ejecutar el Proyecto
1. Abre una terminal en la carpeta del proyecto.
2. Ejecuta el siguiente comando para iniciar la API:
   ```pwsh
   dotnet run
   ```
3. Accede a los endpoints usando un navegador o una herramienta como Postman o curl:
   - [http://localhost:5000/](http://localhost:5000/) (GET)
   - [http://localhost:5000/about](http://localhost:5000/about) (GET)
   - [http://localhost:5000/](http://localhost:5000/) (PUT, DELETE)

## Notas
- Este ejercicio es ideal para comprender la estructura básica de una API mínima en .NET y cómo mapear rutas y métodos HTTP.
- Puedes extender la funcionalidad agregando más rutas o lógica de negocio según sea necesario.
