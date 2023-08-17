using Fiap.Bank.Models;

ContaCorrente contaCorr = new ContaCorrente();
ContaPoupanca contaPoup = new ContaPoupanca(200.0);

contaCorr._agencia = 001;
contaCorr._numConta = 2;
contaCorr._saldo = 250;
contaCorr._dataAbertura = DateTime.Now;
contaCorr._tipo = TipoConta.Comum;