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
    public IActionResult Deportes()
    {
          ViewBag.Deportes=Bd.ListarDeportes();
          return View();
    }

        public IActionResult Paises()
    {
          ViewBag.Paises=Bd.ListarPaises();
          return View();
    }


    public IActionResult ListarDeportistasXDeporte(int idDeporte)
    {
          ViewBag.Deportistas=Bd.ListarDeportistasXDeporte(idDeporte);
          return View("DeportistasDelDeporte");

    }


    
}
