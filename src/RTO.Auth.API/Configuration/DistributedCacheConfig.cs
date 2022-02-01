namespace RTO.Auth.API.Configuration;

public static class DistributedCacheConfig
{
    public static IServiceCollection AddDistributedCacheConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDistributedRedisCache(options =>
        {
            options.Configuration = configuration.GetConnectionString("RedisCs");
            options.InstanceName = "AuthDB-";
        });

        return services;
    }
}
