

using Entities.DTOs;
using Entities.Models;

namespace Services.Contracts;

public interface IExampleService
{
    List<ExampleDto> GetExamples();
    ExampleDto? GetExampleById(int id);
    
}
