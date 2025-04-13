
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Common;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
where TEntity : class, new()
{
    protected readonly RepositoryContext _context;

    public RepositoryBase(RepositoryContext context)
    {
        _context = context;
    }

    private DbSet<TEntity> Table => _context.Set<TEntity>();
    public async Task CreateEntity(TEntity entity)
    {
       await Table.AddAsync(entity);
    }

    public async Task DeleteEntity(TEntity entity)
    {
        await Task.Run(() => Table.Remove(entity));
    }

    public IQueryable<TEntity> FindAll(bool tracking)
    {
        return tracking ? Table : Table.AsNoTracking();
    }

    public TEntity? FindByCondition(Expression<Func<TEntity, bool>> condition, bool tracking)
    {
         return tracking ? Table.Where(condition).SingleOrDefault() : Table.Where(condition).AsNoTracking().SingleOrDefault();
    }

    public async Task UpdateEntity(TEntity entity)
    {
        await Task.Run(() => Table.Update(entity));
    }
}
