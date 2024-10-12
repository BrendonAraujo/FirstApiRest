using FirstRestAPI.Context;

namespace FirstRestAPI.Config;

public static class DBContextConfig
{
    public static WebApplicationBuilder AddDBContextConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ApiDbContext>();
        return builder;
    }
}
