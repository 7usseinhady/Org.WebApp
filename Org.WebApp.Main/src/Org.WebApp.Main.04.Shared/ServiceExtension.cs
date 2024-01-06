using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Org.WebApp.SharedKernel;

namespace Org.WebApp.Main;

public static class ServiceExtension
{
    public static IServiceCollection AddMainShared(this IServiceCollection services, IConfiguration configuration = default)
    {
        services.AddSharedKernelShared(configuration);
        return services;
    }
}
