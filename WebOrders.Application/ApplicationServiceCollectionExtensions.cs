using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebOrders.Application.Database;

namespace WebOrders.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddValidatorsFromAssemblyContaining<IApplicationMarker>(ServiceLifetime.Singleton);

        services.AddDatabase(configuration);
        return services;
    }

    private static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("Default") 
                                  ?? throw new InvalidOperationException("The 'Default' connection string is empty.");
        
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
        
        return services;
    }
}