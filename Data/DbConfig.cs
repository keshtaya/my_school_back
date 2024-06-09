using Microsoft.EntityFrameworkCore;
using my_school.Data.Contexts;

namespace my_school.Data.Configs
{
    public static class DatabaseConfigurations
    {
        public static IServiceCollection ConfigureDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PostgreSqlContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("PostgreSQL"));
            });

            return services;
        }
    }
}

