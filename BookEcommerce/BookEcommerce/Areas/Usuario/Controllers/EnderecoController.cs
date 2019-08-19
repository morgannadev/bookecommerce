using Microsoft.AspNetCore.Mvc;

namespace BookEcommerce.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
