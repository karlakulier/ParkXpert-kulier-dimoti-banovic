using Microsoft.EntityFrameworkCore;
using ParkXplore.Application.Services;
using ParkXplore.Core.Entities;
using ParkXplore.Core.Interfaces;
using ParkXplore.Infrastructure.Context;
using ParkXplore.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracija baze podataka
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registracija Repository-ja i Service-a
builder.Services.AddScoped<IRepository<ParkingSpot>, ParkingSpotRepository>();
builder.Services.AddScoped<IParkingSpotService, ParkingSpotService>();

builder.Services.AddScoped<IRepository<Reservation>, ReservationRepository>();
builder.Services.AddScoped<IReservationService, ReservationService>();


// Dodavanje Swaggera
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Omoguæavanje kontrolera
builder.Services.AddControllers();

var app = builder.Build();

// Primjena migracija pri pokretanju aplikacije
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate();  // Ovdje primjenjujemo migracije automatski
}

// Omoguæavanje Swaggera samo u razvojnom okruženju
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Routing za API
app.UseRouting();

app.MapControllers();

app.Run();
