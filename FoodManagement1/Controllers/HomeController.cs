using FoodManagement1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace FoodManagement1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult AddUser()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult PlaceOrder()
        {
            return View();
        }
        public IActionResult Distributor()
        {
            return View();
        }
        public IActionResult Consultant()
        {
            return View();
        }
        public IActionResult Bank()
        {
            return View();
        }

        public IActionResult Practice()
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
