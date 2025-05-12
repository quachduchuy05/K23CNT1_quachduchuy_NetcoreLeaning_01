using day2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace day2.Controllers
{
    public class QdhHome : Controller
    {
        private readonly ILogger<QdhHome> _logger;

        public QdhHome(ILogger<QdhHome> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
