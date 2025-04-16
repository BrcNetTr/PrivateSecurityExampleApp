
using Entities.Models;
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete;

public class GunQuestionRepository : RepositoryBase<GunQuestion>, IGunQuestionRepository
{
    public GunQuestionRepository(RepositoryContext context) : base(context)
    {
    }
}
