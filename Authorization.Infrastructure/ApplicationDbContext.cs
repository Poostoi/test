
using Authorization.Entities;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Infrastructure;

public class ApplicationDbContext:DbContext
{
    public DbSet<User> Users { get; set; }
    public ApplicationDbContext()
    {
        // Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test;Username=postgres;Password=1");
    }
}