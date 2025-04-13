
using Repositories.Contracts;

namespace Repositories.Common;

public interface IRepositoryManager
{
    IQuestionRepository QuestionRepository { get; }
    IExampleRepository ExampleRepository { get; }

    Task SaveAsync();
    
}
