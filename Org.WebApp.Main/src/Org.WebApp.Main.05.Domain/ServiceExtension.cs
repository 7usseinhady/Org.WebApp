using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Org.WebApp.SharedKernel;

namespace Org.WebApp.Main;

public static class ServiceExtension
{
    public static IServiceCollection AddMainDomain(this IServiceCollection services, IConfiguration configuration = default)
    {
        services.AddSharedKernelDomain(configuration);
        return services;
    }
}
