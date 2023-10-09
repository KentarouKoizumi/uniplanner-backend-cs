using Microsoft.Extensions.DependencyInjection;
using Domain.Interfaces.Repositories;
using MockInfrastructure.Repositories;

namespace Api.DependencyInjection;

public static class DataServiceDI
{
    public static IServiceCollection AddDataServices(this IServiceCollection services)
    {
        services.AddScoped<IEventRepository, MockEventRepository>();
        return services;
    }
}

