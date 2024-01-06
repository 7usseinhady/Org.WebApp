using Org.WebApp.SharedKernel;

namespace Org.WebApp.Main;

public static class ServiceExtension
{
    public static IServiceCollection AddMainApi(this IServiceCollection services, IConfiguration configuration = default)
    {
        services.AddSharedKernelApi(configuration);
        return services;
    }
}