using Fiap.Web.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.API.Persistencia
{
    public class LivrariaContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        public LivrariaContext(DbContextOptions op) : base(op)
        {

        }
    }
}
