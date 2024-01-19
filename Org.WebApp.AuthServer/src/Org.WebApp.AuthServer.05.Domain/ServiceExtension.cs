using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Org.WebApp.SharedKernel;

namespace Org.WebApp.AuthServer;

public static class ServiceExtension
{
    public static IServiceCollection AddAuthServerDomain(this IServiceCollection services, IConfiguration configuration = default)
    {
        services.AddSharedKernelDomain(configuration);
        return services;
    }
}
