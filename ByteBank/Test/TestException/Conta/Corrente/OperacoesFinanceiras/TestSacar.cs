using ByteBank.Contas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Test.TestException.Conta.Corrente.OperacoesFinanceiras
{
    internal class TestSacar
    {
        // Exception -> Valor não pode ser menor que 0.
        public static void SacarValorNegativo(double valor)
        {
            ContaCorrente contaCorrente = new ContaCorrente(123, 123);
            contaCorrente.Sacar(valor);

            Console.WriteLine("Operação feita com sucesso! \nSaldo: " + contaCorrente.Saldo);
        }

        // "O valor do Saque não pode ser menor que Saldo. (Valor do saque: , Valor do Saldo: )
        public static void SacarValorMaiorQueSaldo()
        {
            ContaCorrente contaCorrente = new ContaCorrente(123, 123);
            contaCorrente.Sacar(100);

            Console.WriteLine("Operação feita com sucesso! \nSaldo: " + contaCorrente.Saldo);
        }         
    }
}
