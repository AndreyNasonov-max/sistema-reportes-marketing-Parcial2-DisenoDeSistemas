using Microsoft.OpenApi.Models;
using SistemaReportes.Repositories;
using SistemaReportes.Services;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
builder.Services.AddScoped<VentaRepository>();
builder.Services.AddControllers();
builder.Services.AddScoped<ReporteService>();


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API Sistema Reportes Andrey",
        Version = "v1"
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();


app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi(); ← no necesaria, opcional
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};


app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
