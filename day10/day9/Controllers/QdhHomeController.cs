using day9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace day9.Controllers
{
    public class QdhHomeController : Controller
    {
        private readonly ILogger<QdhHomeController> _logger;

        public QdhHomeController(ILogger<QdhHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult QdhIndex() 
        {
            return View();
        }

        public IActionResult QdhAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
