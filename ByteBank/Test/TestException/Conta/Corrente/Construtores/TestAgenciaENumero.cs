using ByteBank.Contas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Test.TestException.Conta.Corrente.Construtores
{
    public class TestAgenciaENumero
    {
        // Exception -> Agencia não pode ser menor ou igual a 0.
        public static void AgenciaNaoPodeSerMenorOuIgualAZero(int agencia)
        {
            ContaCorrente contaCorrente = new ContaCorrente(agencia, 123);

            contaCorrente.ConfereNumeroEAgencia(agencia, 123);
            Console.WriteLine("Agencia valida " + contaCorrente.Agencia);
        }

        // Exception -> Numero não pode ser menor ou igual a 0
        public static void NumeroNaoPodeSerMenorOuIgualAZero(int numero)
        {
            ContaCorrente contaCorrente = new ContaCorrente(123, numero);

            contaCorrente.ConfereNumeroEAgencia(123, numero);
            Console.WriteLine("Agencia numero" + contaCorrente.Numero);
        }
    }
}
