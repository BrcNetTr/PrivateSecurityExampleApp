
using Services.Contracts;

namespace Services.Common;

public interface IServiceManager
{
    IExampleService ExampleService { get; }
}
