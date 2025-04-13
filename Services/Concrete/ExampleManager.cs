
using AutoMapper;
using Entities.DTOs;
using Entities.Models;
using Repositories.Common;
using Services.Contracts;

namespace Services.Concrete;

public class ExampleManager : IExampleService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;

    public ExampleManager(IRepositoryManager repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public ExampleDto? GetExampleById(int id)
    {
        var example = _repository.ExampleRepository.FindByCondition( x=> x.Id == id, false);
        var mappingExample = _mapper.Map<ExampleDto>(example);
        return mappingExample;
    }

    public List<ExampleDto> GetExamples()
    {
        var examples = _repository.ExampleRepository.FindAll(false).ToList();
        var mappingExamples =  _mapper.Map<List<ExampleDto>>(examples);
        return mappingExamples;
    }
}
