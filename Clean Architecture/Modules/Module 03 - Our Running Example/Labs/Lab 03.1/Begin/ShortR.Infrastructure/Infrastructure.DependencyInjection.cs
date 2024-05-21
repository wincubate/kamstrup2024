using Microsoft.Extensions.DependencyInjection;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Infrastructure.Persistence;

namespace ShortR.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services
            .AddSingleton<IShortenedUrlRepository, InMemoryShortenedUrlRepository>();

        return services;
    }
}
