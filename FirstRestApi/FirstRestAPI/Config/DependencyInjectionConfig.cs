using Business.Interfaces;
using Data.Repositories;

namespace FirstRestAPI.Config;

public static class DependencyInjectionConfig
{
    public static IServiceCollection ApplyDependencyInjection(this IServiceCollection services)
    {
        //services.AddScoped<ApiDbContext>();
        services.AddScoped<ISupplierRepository, SupplierRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();

        return services;
    }
}
