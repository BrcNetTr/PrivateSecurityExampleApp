
using Repositories.Contracts;

namespace Repositories.Common;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private readonly IQuestionRepository _questionRepository;
    private readonly IExampleRepository _exampleRepository;

    public RepositoryManager(RepositoryContext context, IQuestionRepository questionRepository, IExampleRepository exampleRepository)
    {
        _context = context;
        _questionRepository = questionRepository;
        _exampleRepository = exampleRepository;
    }

    public IQuestionRepository QuestionRepository => _questionRepository;

    public IExampleRepository ExampleRepository => _exampleRepository;

    public async Task SaveAsync()
    {
      await  _context.SaveChangesAsync();
    }
}
