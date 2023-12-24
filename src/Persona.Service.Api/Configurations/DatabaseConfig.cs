using Microsoft.EntityFrameworkCore;
using Persona.Infra.Data.PostgreSQL.Context;

namespace Persona.Service.Api.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddDbContext<PersonaContext>(options => options.UseNpgsql(configuration.GetConnectionString("PersonaConnection")));
            services.AddDbContext<EventStoreSqlContext>(options => options.UseNpgsql(configuration.GetConnectionString("PersonaConnection")));
        }

    }
}
