using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("Tb_Ator")]
    public class Ator
    {
        [Column("Id"), HiddenInput]
        public int AtorId { get; set; }

        [Required, MaxLength(80)]
        public string? Nome { get; set; }

        [Column("DataNascimento"), Display(Name = "Data de Nascimento"), DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public Nacionalidade Nacionalidade { get; set; }

        public bool Premiado { get; set; }

        //N:M
        public IList<FilmeAtor> FilmesAtores { get; set; }
    }

    public enum Nacionalidade
    {
        Brasileira, Italiana, Americana, Inglesa
    }
}
