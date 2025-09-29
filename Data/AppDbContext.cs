using Microsoft.EntityFrameworkCore;
using CerealDatabase.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cereal> Cereals { get; set; }
}
