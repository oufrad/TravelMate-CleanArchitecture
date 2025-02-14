using Microsoft.EntityFrameworkCore;
using TravelMate.Domain.Entities;

namespace TravelMate.Infrastructure.Persistence;

public class TravelMateDbContext: DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public TravelMateDbContext(DbContextOptions options): base(options)
    {
        {
            try
            {
                Database.EnsureCreated();  // This will help us verify if we can actually connect
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database connection error: {ex.Message}");
                throw;
            }
        }
    }
}
