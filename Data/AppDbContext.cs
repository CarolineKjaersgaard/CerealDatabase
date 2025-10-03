using Microsoft.EntityFrameworkCore;
using CerealDatabase.Models;

// Representing a working database for cereals 
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cereal> Cereals { get; set; } // Databaseset of cereals

    // Creates a cereal database with name as primary key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cereal>()
            .HasKey(c => c.Name);
    }

}
