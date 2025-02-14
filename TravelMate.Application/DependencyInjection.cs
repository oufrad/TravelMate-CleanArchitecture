using Microsoft.Extensions.DependencyInjection;

namespace TravelMate.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //return service.AddScoped<>();
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));
        });
        return services;
    }
}
