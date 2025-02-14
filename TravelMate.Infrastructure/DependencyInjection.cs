using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Infrastructure.Persistence;
using TravelMate.Infrastructure.Persistence.Repositories;

namespace TravelMate.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
    this IServiceCollection services,
    IConfiguration configuration)  // Add this parameter
    {
        services.AddDbContext<TravelMateDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPostRepository, PostRespository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
        return services;
    }
}
