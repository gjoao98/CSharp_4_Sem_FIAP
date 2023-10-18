using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("Tb_Filme_Ator")]
    public class FilmeAtor
    {
        public Filme Filme { get; set; }
        public int FilmeId { get; set; }
        public Ator Ator { get; set; }
        public int AtorId { get; set; }
    }
}
