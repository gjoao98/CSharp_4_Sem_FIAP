using Fiap.Web.Aula03.DataBase;
using Fiap.Web.Aula03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Fiap.Web.Aula03.Controllers
{
    public class FilmeController : Controller
    {        
        private StreamingContext _context;

        public FilmeController(StreamingContext context)
        {
            _context = context;
        }

        private void CarregarProdutoras()
        {
            var lista = _context.Produtoras.ToList();
            ViewBag.produtoras = new SelectList(lista, "ProdutoraId", "Nome");
        }

        public IActionResult Index(string filme)
        {
            var lista = _context.Filmes
                .Where(f => f.Titulo.Contains(filme) || filme == null)
                .Include(p => p.Produtora)
                .ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarProdutoras();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            TempData["msg"] = "Filme registrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarProdutoras();
            var filme = _context.Filmes.Find(id);
            return View(filme);
        }

        [HttpPost]
        public IActionResult Editar(Filme filme)
        {
            _context.Filmes.Update(filme);
            _context.SaveChanges();
            TempData["msg"] = "Filme atualizado!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var filme = _context.Filmes.Find(id);
            _context.Filmes.Remove(filme);
            _context.SaveChanges();
            TempData["msg"] = "Filme removido";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var atores = _context.Atores.ToList();
            ViewBag.atores = atores;
            var filme = _context.Filmes
                .Include(p => p.Produtora)
                .First(f => f.FilmeId == id);
            return View(filme);
        }
    }
}
