using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Bank.Models
{
    abstract class Conta
    {
        public int _agencia { get; set; }
        public int _numConta { get; set;}
        public DateTime _dataAbertura { get; set; }
        public decimal _saldo { get; set; }

        public abstract void Depositar (decimal valor);
        public abstract void Retirar (decimal valor);
    }
}
