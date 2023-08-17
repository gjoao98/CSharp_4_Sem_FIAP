using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    public class Aluno: Pessoa
    {
        // Propriedades
        public DateTime DataMatricula { get; set; }

        public bool Status { get; set; }
    }
}
