using Microsoft.AspNetCore.Mvc;
using MvcCoreDeployment.Models;
using System.Diagnostics;

namespace MvcCoreDeployment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["SALUDO"] = "Nuestra app Deployment lunes";
            Random random = new Random();
            List<int> nums = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                int nun = random.Next(1, 50);
                nums.Add(nun);
            }
            return View(nums);
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
