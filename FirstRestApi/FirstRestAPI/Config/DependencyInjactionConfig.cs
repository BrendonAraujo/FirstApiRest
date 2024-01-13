using Business.Interfaces;
using Data.Repositories;
using FirstRestAPI.Context;

namespace FirstRestAPI.Config;

public static class DependencyInjactionConfig
{
    public static IServiceCollection ApplyDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<ApiDbContext>();
        services.AddScoped<ISupplierRepository, SupplierRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();

        return services;
    }
}
