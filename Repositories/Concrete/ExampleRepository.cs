
using Entities.Models;
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete;

public class ExampleRepository : RepositoryBase<Example>, IExampleRepository
{
    public ExampleRepository(RepositoryContext context) : base(context)
    {
    }
    
}
