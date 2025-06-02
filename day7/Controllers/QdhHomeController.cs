using day7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace day7.Controllers
{
    public class NvkHomeController : Controller
    {
        private readonly ILogger<NvkHomeController> _logger;

        public NvkHomeController(ILogger<NvkHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NvkIndex()
        {
            return View();
        }

        public IActionResult NvkAbout()
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