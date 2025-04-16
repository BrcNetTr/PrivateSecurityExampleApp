using System;
using Services.Contracts;

namespace Services.Common;

public class ServiceManager : IServiceManager
{
    private readonly IExampleService _exampleService;

    public ServiceManager(IExampleService exampleService)
    {
        _exampleService = exampleService;
    }

    public IExampleService ExampleService => _exampleService;
}
