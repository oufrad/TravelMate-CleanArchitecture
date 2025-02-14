using Microsoft.EntityFrameworkCore;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.User;

namespace TravelMate.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly TravelMateDbContext _context;
    public UserRepository(TravelMateDbContext context)
    {
        _context = context; 
    }
    public async Task<User> AddUser(User user)
    {
        var result = await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetById(int id)
    {
        return await _context.Users.FindAsync(id);

    }
}
