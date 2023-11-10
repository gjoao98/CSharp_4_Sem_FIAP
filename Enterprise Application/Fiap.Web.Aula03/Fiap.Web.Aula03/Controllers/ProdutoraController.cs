using Fiap.Web.Aula03.DataBase;
using Fiap.Web.Aula03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public void CarregarPresidentes()
        {
            var lista = _context.Presidentes.ToList();
            ViewBag.Lista = new SelectList(lista, "PresidenteId", "Nome");
        }

        public IActionResult Index(string produtora)
        {
            var lista = _context.Produtoras
                .Include(p => p.Presidente)
                .Where(p => p.Nome.Contains(produtora) || produtora == null)
                .ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarPresidentes();
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

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarPresidentes();
            var produtora = _context.Produtoras.First(p => p.ProdutoraId == id);
            return View(produtora);
        }

        [HttpPost]
        public IActionResult Editar(Produtora produtora) 
        {
            _context.Produtoras.Update(produtora);
            _context.SaveChanges();
            TempData["msg"] = "Produtora atualizada!";
            return RedirectToAction("Index");
        }
    }
}
