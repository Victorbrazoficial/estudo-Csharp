using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Exceptions
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }

        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }
        
        public SaldoInsuficienteException(double saldo, double valorSaque) : this("O valor do Saque não pode ser maior que o Saldo. (Valor do saque: " + valorSaque + ". Saldo na Conta: " + saldo + ").")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
