using Application.UseCases.Event.GetEvents;
using Application.UseCases.Root.Greeting;
using Microsoft.Extensions.DependencyInjection;


namespace Api.DependencyInjection;

public static class UseCaseDI
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IGreetingUseCase, GreetingUseCase>();
        services.AddScoped<IGetEventsUseCase, GetEventsUseCase>();

        return services;
    }
}