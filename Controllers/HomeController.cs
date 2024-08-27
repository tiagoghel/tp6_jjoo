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


    public IActionResult ListarDeportistasXDeporte(int iddeporte)
    {
          ViewBag.Deportistas=Bd.ListarDeportistasXDeporte(iddeporte);
          return View("DeportistasDelDeporte");

    }
    public IActionResult ListarDeportistasXPais(int idpais)
    {
          ViewBag.Deportista=Bd.ListarDeportistasXPais(idpais);
          return View("DeportistasDelPais");
    }
      public IActionResult VerDetalleDeporte(int idDeporte)
    {
          ViewBag.Deporte=Bd.VerInfoDeporte(idDeporte);
          ViewBag.Deportista=Bd.ListarDeportistasXDeporte(idDeporte);
          return View();
    }
      public IActionResult VerDetallePais(int IdPais)
    {
          ViewBag.Paises=Bd.VerInfoPais(IdPais);
          ViewBag.Deportista=Bd.ListarDeportistasXPais(IdPais);
          return View();
    }

          public IActionResult VerDetalleDeportista(int idDeportista)
    {
          ViewBag.Deportista=Bd.VerInfoDeportista(idDeportista);
          return View();
    }
     public IActionResult AgregarDeportista()
    {
        ViewBag.Paises = Bd.ListarPaises();
        ViewBag.Deportes = Bd.ListarDeportes();
        return View();
    }
    public IActionResult GuardarDeportista(Deportistas dep)
    {
      Bd.AgregarDeportista(dep);
      return View("Index");
    }




    
}
