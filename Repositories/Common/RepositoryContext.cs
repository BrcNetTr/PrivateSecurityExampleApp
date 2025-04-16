
using System.Reflection;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Common;

public class RepositoryContext:DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
    {
        
    }

    public DbSet<Example> Examples { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<GunQuestion> GunQuestions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
