using Microsoft.AspNetCore.Mvc;
using BookEcommerce.Areas.Usuario.Models;
using System.Diagnostics;

namespace BookEcommerce.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
