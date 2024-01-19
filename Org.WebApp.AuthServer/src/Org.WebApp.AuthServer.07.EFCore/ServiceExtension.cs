using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Org.WebApp.SharedKernel;

namespace Org.WebApp.AuthServer;

public static class ServiceExtension
{
    public static IServiceCollection AddAuthServerEFCore(this IServiceCollection services, IConfiguration configuration = default)
    {
        services.AddSharedKernelEFCore(configuration);
        return services;
    }
}
