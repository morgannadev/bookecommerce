using Microsoft.AspNetCore.Mvc;

namespace BookEcommerce.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class CartaoCreditoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
