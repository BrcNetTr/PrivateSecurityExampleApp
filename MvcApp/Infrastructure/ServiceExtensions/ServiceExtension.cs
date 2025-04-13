
using Microsoft.EntityFrameworkCore;
using Repositories.Common;

namespace MvcApp.Infrastructure.ServiceExtensions;

public static class ServiceExtension
{
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RepositoryContext>(options =>{
            options.UseSqlite(configuration.GetConnectionString("SqliteConnection"));
        });
    }
}
