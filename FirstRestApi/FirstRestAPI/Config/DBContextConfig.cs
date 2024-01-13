using FirstRestAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace FirstRestAPI.Config;

public static class DBContextConfig
{
    public static WebApplicationBuilder AddDBContextConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ApiDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
        );
        return builder;
    }
}
