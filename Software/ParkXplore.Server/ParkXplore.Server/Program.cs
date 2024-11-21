using Microsoft.EntityFrameworkCore;
using ParkXplore.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracija baze podataka
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dodavanje Swaggera
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Omogu�avanje kontrolera
builder.Services.AddControllers();

var app = builder.Build();

// Omogu�avanje Swaggera samo u razvojnom okru�enju
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Routing za API
app.UseRouting();

app.MapControllers();

app.Run();
