using Org.WebApp.SharedKernel;

namespace Org.WebApp.Main;

public static class ServiceExtension
{
    public static IServiceCollection AddMainApi(this IServiceCollection services, IConfiguration configuration = default)
    {
        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        #region IOC Container for layers
        services.AddMainEFCore(configuration);
        services.AddMainInfrastructure(configuration);
        services.AddMainDomain(configuration);
        services.AddMainShared(configuration);
        services.AddMainContract(configuration);
        services.AddMainUseCases(configuration);

        services.AddSharedKernelApi(configuration);
        #endregion


        return services;
    }
}