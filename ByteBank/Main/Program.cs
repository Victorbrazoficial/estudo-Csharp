using System;

using ByteBank.Test.TestException.Conta.Corrente.OperacoesFinanceiras;
using ByteBank.Test.TestException.Conta.Corrente.Construtores;
using ByteBank.Test.TestException.TestLeitorDeArquivo;

namespace ByteBank.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TestDeposita.DepositaValorNegativo(100);
            //TestSacar.SacarValorNegativo(1);
            //TestTransferir.TransferirValorNegativo(50);
            TestAgenciaENumero.AgenciaNaoPodeSerMenorOuIgualAZero(1);
            //TestAgenciaENumero.NumeroNaoPodeSerMenorOuIgualAZero(1);
            //TestLeitorDeArquivo.TestMetodoDispose();

        }
    }
}
    