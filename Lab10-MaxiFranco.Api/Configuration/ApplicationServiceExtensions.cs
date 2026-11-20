using Lab10_MaxiFranco.Application.UseCases.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace Lab10_MaxiFranco.Api.Configuration;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var types = typeof(LoginUseCase).Assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsPublic &&
                        (t.Name.EndsWith("UseCase") || t.Name.EndsWith("UseCases")));
        foreach (var type in types) services.AddScoped(type);
        return services;
    }
}