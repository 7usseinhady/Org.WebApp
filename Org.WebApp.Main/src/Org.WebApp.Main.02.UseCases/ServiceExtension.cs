using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Org.WebApp.SharedKernel;

namespace Org.WebApp.Main;

public static class ServiceExtension
{
    public static IServiceCollection AddMainUseCases(this IServiceCollection services, IConfiguration configuration = default)
    {
        services.AddSharedKernelUseCases(configuration);
        return services;
    }
}
