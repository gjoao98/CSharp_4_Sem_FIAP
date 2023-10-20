using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("Tb_Presidente")]
    public class Presidente
    {
        [Column("Id")]
        public int PresidenteId { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Display(Name = "Data de Nascimento"), DataType(DataType.Date)]
        public DateTime DataNascimento { get; set;}
    }
}
