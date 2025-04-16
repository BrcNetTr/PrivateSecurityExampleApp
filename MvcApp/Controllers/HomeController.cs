using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using Services.Common;

namespace MvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IServiceManager _serviceManager;
    public HomeController(ILogger<HomeController> logger, IServiceManager serviceManager)
    {
        _logger = logger;
        _serviceManager = serviceManager;
    }

    public IActionResult Index()
    {
        var examples = _serviceManager.ExampleService.GetExamples();
        return View(examples);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
