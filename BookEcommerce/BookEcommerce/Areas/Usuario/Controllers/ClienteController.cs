using Microsoft.AspNetCore.Mvc;

namespace BookEcommerce.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente()
        {
            return View();
        }

        public IActionResult PerfilCliente()
        {
            return View();
        }

        public IActionResult EditarCliente()
        {
            return View();
        }
    }
}
