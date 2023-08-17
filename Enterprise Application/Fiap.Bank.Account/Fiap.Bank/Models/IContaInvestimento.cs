using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Bank.Models
{
    internal interface IContaInvestimento
    {

        float CalculaRetornoInvestimento(decimal percent, decimal investiment); 
    }
}
