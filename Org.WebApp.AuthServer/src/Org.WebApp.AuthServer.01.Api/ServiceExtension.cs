using Org.WebApp.SharedKernel;

namespace Org.WebApp.AuthServer;

public static class ServiceExtension
{
    public static IServiceCollection AddAuthServerApi(this IServiceCollection services, IConfiguration configuration = default)
    {
        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        #region IOC Container for layers
        services.AddAuthServerEFCore(configuration);
        services.AddAuthServerInfrastructure(configuration);
        services.AddAuthServerDomain(configuration);
        services.AddAuthServerShared(configuration);
        services.AddAuthServerContract(configuration);
        services.AddAuthServerUseCases(configuration);

        services.AddSharedKernelApi(configuration);
        #endregion


        return services;
    }
}