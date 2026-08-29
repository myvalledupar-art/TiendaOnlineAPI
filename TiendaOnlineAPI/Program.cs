using TiendaOnlineAPI.Data; // 👈 Importa tu DbContext real
using Microsoft.EntityFrameworkCore; // 👈 Necesario para UseSqlServer

var builder = WebApplication.CreateBuilder(args);

// 👉 Agregamos servicios básicos para Swagger y API Explorer
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 👉 Registramos el DbContext y le decimos que use la cadena de conexión del appsettings.json
builder.Services.AddDbContext<TiendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 👉 Registramos los controladores
builder.Services.AddControllers();

var app = builder.Build();

// 👉 Configuramos el pipeline de la aplicación
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 👉 Aquí se mapean los controladores
app.MapControllers();

// 👉 Endpoint de prueba (puedes dejarlo o quitarlo)
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

// 👉 Clase record para el endpoint de prueba
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}





