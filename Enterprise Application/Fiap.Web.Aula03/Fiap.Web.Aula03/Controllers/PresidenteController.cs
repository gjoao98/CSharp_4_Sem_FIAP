using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula03.Controllers
{
    public class PresidenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
