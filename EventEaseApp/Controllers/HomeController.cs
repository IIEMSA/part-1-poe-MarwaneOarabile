using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EventEaseApp.Models;

namespace EventEaseApp.Controllers;
// this code was sourced from Juliana Adeola Adisa lessons and modified to fit the project

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
