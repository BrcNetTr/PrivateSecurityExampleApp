using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Repositories.Common;

public interface IRepositoryBase<T>
where T : class, new()
{
    IQueryable<T> FindAll(bool tracking);
    T? FindByCondition(Expression<Func<T, bool>> condition, bool tracking);

    Task CreateEntity(T entity);
    Task UpdateEntity(T entity);
    Task DeleteEntity(T entity);
    
}
