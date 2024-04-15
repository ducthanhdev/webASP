using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webASP.Models;

namespace webASP.Controllers;

public class AboutController : Controller
{
    private readonly ILogger<AboutController> _logger;

    public AboutController(ILogger<AboutController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Info()
    {
        Console.WriteLine("Check: " + Request.Query["id"].ToString());
        return View();
    }

    public IActionResult Introduce()
    {
        return View();
    }

    public IActionResult PolicyBooking()
    {
        return View();
    }

    public IActionResult PriceList()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
