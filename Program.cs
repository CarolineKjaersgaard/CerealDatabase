using Microsoft.EntityFrameworkCore;
using System;
using CsvHelper;
using CsvHelper.Configuration;


//Initializes builder, registers database and configures it to use SQLite
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

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
    Seeder seeder = new Seeder(db);
    seeder.Seed("Data/Cereal.csv");
    Controller controller = new Controller(db);
}

app.UseHttpsRedirection();

app.Run();

