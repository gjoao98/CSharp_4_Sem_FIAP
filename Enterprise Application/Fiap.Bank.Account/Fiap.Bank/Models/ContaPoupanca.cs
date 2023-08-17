using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Bank.Models
{
    internal class ContaPoupanca : Conta
    {
        public decimal _taxa { get; set; }
        public decimal _rendimento { get; }

        ContaPoupanca(decimal valor)
        {
            _rendimento = valor;
        }

        public ContaPoupanca(double v)
        {
            this.v = v;
        }

        public override void Depositar(decimal valor)
        {
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public override void Retirar(decimal valor)
        {
            Console.WriteLine("Saque realizado com sucesso!");
        }

        public decimal CalculaRetornoInvestimento()
        {
            return _saldo * _rendimento;
        }
    }
}
