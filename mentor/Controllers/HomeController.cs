using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mentor.Models;

namespace mentor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
        [Route("Index")]

    public IActionResult Index()
    {
        return View();
    }
        [Route("Pricing")]

        public IActionResult Pricing()
    {
        return View();
    }
        [Route("Events")]
    
        public IActionResult Events()
    {
        return View();
    }
        [Route("Courses")]
    
        public IActionResult Courses()
    {
        return View();
    }
        [Route("Contact")]
    public IActionResult Contact()
    {
        return View();
    }
        
        [Route ("About")]
        public IActionResult About()
    {
        return View();
    }

          [Route ("Trainers")]
    public IActionResult Trainers()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
