using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp6_jjoo.Models;

namespace tp6_jjoo.Controllers;

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
    
}
