using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Bank.Models
{
    internal class ContaCorrente: Conta
    {
        public TipoConta _tipo { get; set; }
        public override void Depositar(decimal valor)
        {
            _saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (_tipo == TipoConta.Comum && _saldo < valor)
            {
                throw new ArgumentException();
            } else
            {
                _saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
        }
    }
}
