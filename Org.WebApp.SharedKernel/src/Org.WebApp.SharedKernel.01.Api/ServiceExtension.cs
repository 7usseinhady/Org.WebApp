using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Org.WebApp.SharedKernel;

public static class ServiceExtension
{
    public static IServiceCollection AddSharedKernelApi(this IServiceCollection services, IConfiguration configuration = default)
    {
        return services;
    }
}
