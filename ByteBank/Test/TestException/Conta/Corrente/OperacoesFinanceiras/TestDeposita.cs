using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Contas;

namespace ByteBank.Test.TestException.Conta.Corrente.OperacoesFinanceiras
{
    public class TestDeposita
    {
        // Exception -> O Valor inserido não pode ser negativo.
        public static void DepositaValorNegativo(double valor)
        {
            ContaCorrente contaCorrente = new ContaCorrente(123, 123);
            
            contaCorrente.Depositar(valor);
            Console.WriteLine("Operação feita com sucesso! \nSaldo: " + contaCorrente.Saldo);
        }
    }
}
