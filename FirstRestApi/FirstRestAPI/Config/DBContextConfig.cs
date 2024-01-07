using FirstRestAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace FirstRestAPI.Config;

public static class DBContextConfig
{
    public static IServiceCollection AddDBContextConfig(this IServiceCollection serivces)
    {
        var connectionString = "";
        serivces.AddDbContext<ApiDbContext>(options =>
            options.
            UseSqlServer(connectionString));
        return serivces;
    }
}
