using Fiap.Web.Aula03.DataBase;
using Fiap.Web.Aula03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.Aula03.Controllers
{
    public class ProdutoraController : Controller
    {

        private StreamingContext _context;

        public ProdutoraController(StreamingContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var lista = _context.Produtoras.Include(p => p.Presidente).ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produtora produtora)
        {
            _context.Produtoras.Add(produtora);
            _context.SaveChanges();
            TempData["msg"] = "Produtora cadastrada com sucesso";
            return RedirectToAction("Cadastrar");
        }
    }
}
