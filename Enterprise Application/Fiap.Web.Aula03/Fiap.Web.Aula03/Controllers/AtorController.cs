using Fiap.Web.Aula03.DataBase;
using Fiap.Web.Aula03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula03.Controllers
{
    public class AtorController : Controller
    {
        private StreamingContext _context;
        public AtorController(StreamingContext context) 
        {
            _context = context; 
        }

        public IActionResult Index(string nome)
        {
            var lista = _context.Atores
                .Where(a => a.Nome.Contains(nome) || nome == null)
                .ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Ator ator)
        {
            _context.Atores.Add(ator);
            _context.SaveChanges();
            TempData["msg"] = "Ator Cadastrado";
            return RedirectToAction("Index");
        }
    }
}
