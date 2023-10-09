using Microsoft.Extensions.DependencyInjection;

namespace Api.DependencyInjection;

public static class DataServiceDI
{
    public static IServiceCollection AddDataServices(this IServiceCollection services)
    {
        return services;
    }
}

