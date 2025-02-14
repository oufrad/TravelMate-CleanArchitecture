using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TravelMate.Domain.User;

namespace TravelMate.Infrastructure.Persistence;

public class TravelMateDbContext: DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public TravelMateDbContext(DbContextOptions options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
