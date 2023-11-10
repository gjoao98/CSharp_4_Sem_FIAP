using Fiap.Web.API.Models;
using Fiap.Web.API.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private LivrariaContext _context;

        public LivroController(LivrariaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Livro>> Get()
        {
            return _context.Livros.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Livro> Get(int id)
        {
            var livro = _context.Livros.Find(id);

            if (livro == null)
            {
                return NotFound();
            }

            return Ok(livro);
        }

        [HttpPost]
        public ActionResult<Livro> Create(Livro livro) 
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
            return CreatedAtAction("Get", new { id = livro.Id }, livro);
        }

        [HttpPut("{id}")]
        public ActionResult<Livro> Update(int id, Livro livro)
        {
            var busca = _context.Livros.Find(id);
            if (busca == null)
            {
                return NotFound();
            }
            _context.Entry<Livro>(busca).State = EntityState.Detached;
            livro.Id = id;

            _context.Livros.Update(livro);
            _context.SaveChanges();
            return CreatedAtAction("Get", new {id = livro.Id}, livro);

        }

        [HttpDelete("{id}")]
        public ActionResult<Livro> Delete(int id)
        {
            var livro = _context.Livros.Find(id);
            if(livro == null)
            {
                return NotFound();
            }
            _context.Livros.Remove(livro);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
