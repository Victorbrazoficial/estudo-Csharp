using ByteBank.Contas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Test.TestException.Conta.Corrente.OperacoesFinanceiras
{
    public class TestTransferir
    {
        // Exception -> O valor da Transferencia não pode ser negativo.
        public static void TransferirValorNegativo(double valor)
        {
            ContaCorrente contaCorrente3 = new ContaCorrente(123,123);
            ContaCorrente contaCorrente4 = new ContaCorrente(321, 321);

            contaCorrente3.Transferir(valor, contaCorrente4);

            Console.WriteLine("Operação feita com sucesso! \nSaldo Conta03: " + contaCorrente3.Saldo);
            Console.WriteLine("Saldo Conta04: " + contaCorrente4.Saldo);
        }

        // Exception -> Transferência não realizada. Saldo insuficiente.
        public static void TrasferirValorMaiorQueSaldo(double valor)
        {
            ContaCorrente contaCorrente3 = new ContaCorrente(123, 123);
            ContaCorrente contaCorrente4 = new ContaCorrente(321, 321);

            contaCorrente3.Transferir(valor, contaCorrente4);

            Console.WriteLine("Operação feita com sucesso! \nSaldo Conta03: " + contaCorrente3.Saldo);
            Console.WriteLine("Saldo Conta04: " + contaCorrente4.Saldo);
        }
    }
}
