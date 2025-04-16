
using Microsoft.EntityFrameworkCore;
using Repositories.Common;
using Repositories.Concrete;
using Repositories.Contracts;
using Services.Common;
using Services.Concrete;
using Services.Contracts;

namespace MvcApp.Infrastructure.ServiceExtensions;

public static class ServiceExtension
{
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RepositoryContext>(options =>{
            options.UseSqlite(configuration.GetConnectionString("SqliteConnection"));
        });
    }

    public static void ConfigureRepositoryServices(this IServiceCollection services)
    {
          services.AddScoped<IRepositoryManager, RepositoryManager>();
          services.AddScoped<IExampleRepository, ExampleRepository>();
          services.AddScoped<IQuestionRepository, QuestionRepository>();
          services.AddScoped<IGunQuestionRepository, GunQuestionRepository>();

    }
    public static void ConfigureServiceServices(this IServiceCollection services)
    {
          services.AddScoped<IServiceManager, ServiceManager>();
          services.AddScoped<IExampleService, ExampleManager>();

    }
}
