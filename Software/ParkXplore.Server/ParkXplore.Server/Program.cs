using Microsoft.EntityFrameworkCore;
using ParkXplore.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracija baze podataka
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dodavanje Swaggera
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Omoguæavanje kontrolera
builder.Services.AddControllers();

var app = builder.Build();

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
