using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dervishi.joel._5i.PrimaWeb.Models;

namespace dervishi.joel._5i.PrimaWeb.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Prodotto()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Prenota()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Prenota(Prenotazione p)
    {
        return View(p);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}