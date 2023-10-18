using Fiap.Web.Aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.Aula03.DataBase
{
    //Classe que gerencia as entidades
    public class StreamingContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Produtora> Produtoras { get; set; }
        public DbSet<Presidente> Presidentes { get; set; }
        public DbSet<FilmeAtor> FilmeAtor { get; set; }

        public StreamingContext(DbContextOptions op):base(op)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configura a chave composta da tabela associativa
            modelBuilder.Entity<FilmeAtor>().HasKey(c => new {c.FilmeId, c.AtorId});

            //Configura a relação da tabela associativa com o Filme
            modelBuilder.Entity<FilmeAtor>()
                .HasOne(f => f.Filme)
                .WithMany(f => f.FilmesAtores)
                .HasForeignKey(f => f.FilmeId);

            //Configura a relação da tabela associativa com o Ator
            modelBuilder.Entity<FilmeAtor>()
                .HasOne(f => f.Ator)
                .WithMany(f => f.FilmesAtores)
                .HasForeignKey(f => f.AtorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
