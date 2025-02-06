// Program.cs
using TareasBlazor.Servicios;

// Se crea el builder de la aplicación.
var builder = WebApplication.CreateBuilder(args);

// Se agregan los servicios de Razor Pages y Blazor Server al contenedor de servicios.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Se registran los servicios personalizados:
// - SesionUsuarioService: gestiona la sesión del usuario actual (Scoped).
// - UsuariosService: almacena los usuarios en memoria (Singleton).
// - EventosService: almacena los eventos en memoria (Singleton).
// - ServicioAsistencia: gestiona el seguimiento de asistencia (Scoped).
builder.Services.AddScoped<SesionUsuarioService>();
builder.Services.AddSingleton<UsuariosService>();
builder.Services.AddSingleton<EventosService>();
builder.Services.AddScoped<ServicioAsistencia>();

// Se construye la aplicación.
var app = builder.Build();

// Configuración del pipeline HTTP.
if (!app.Environment.IsDevelopment())
{
    // En producción, se utiliza un manejador de errores y HSTS para mayor seguridad.
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Se redirige HTTP a HTTPS.
app.UseHttpsRedirection();

// Se sirven los archivos estáticos (CSS, JS, imágenes, etc.).
app.UseStaticFiles();

// Se configura el enrutamiento.
app.UseRouting();

// Se mapean el hub de Blazor y se define la página _Host como fallback.
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// Se inicia la aplicación.
app.Run();
