using Microsoft.EntityFrameworkCore;
using System;
using CsvHelper;
using CsvHelper.Configuration;


//Initializes builder, registers database and configures it to use SQLite
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// If "dotnet run -- --test" is input in termanal, runs driver tests
if (args.Contains("--test"))
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    Driver driver = new Driver(db);
    driver.Run();
    return;
}

// Starting webserver
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
    Seeder seeder = new Seeder(db);
    seeder.Seed("Data/Cereal.csv");
    CerealController controller = new CerealController(db);
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


if (!app.Environment.IsProduction())
{
    app.UseHttpsRedirection();
}

app.MapControllers();
app.Run();

