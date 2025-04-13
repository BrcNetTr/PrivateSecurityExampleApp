
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
}
