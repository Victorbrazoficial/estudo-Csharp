
using System;
using ByteBank.Clientes;
using ByteBank.Exceptions;


namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public int Agencia { get; }

        public int Numero { get; }

        public double Saldo { get; private set; }
        
        public static int TotaldeDeContas { get; private set; }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        
        public ContaCorrente(int agencia, int numero)
        {
            ConfereNumeroEAgencia(agencia, numero);
            
            Agencia = agencia;
            Numero = numero;
            Saldo = 100;

            ContaCorrente.TotaldeDeContas++;
        }

        public double Sacar(double valor)
        {
            if (Saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
                            
            if (valor < 0)
                throw new ArgumentException("Exception -> O Valor do saque não pode ser negativo.", nameof(valor));           

            Saldo -= valor;
            return Saldo;                           
        }

        public double Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Exception -> O valor do Deposito não pode ser negativo.", nameof (valor));
            
            return Saldo += valor;
        }

        public double Transferir(double valor, ContaCorrente conta)
        {         
            if (valor < 0)
                throw new ArgumentException("Exception -> O valor da Transferencia não pode ser negativo.", nameof(valor));

            if (conta == null)
                throw new ArgumentNullException(nameof(conta));

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Transferência não realizada. Saldo insuficiente.", e);
            }

            return conta.Depositar(valor);         
        }

        public void ConfereNumeroEAgencia(int agencia, int numero)
        {
            if (agencia <= 0)
                throw new ArgumentException("Exception -> Agencia não pode ser menor ou igual a 0.", nameof(agencia));

            if (numero <= 0)
                throw new ArgumentException("Numero não pode ser menor ou igual 0.", nameof(numero));
        }
    }
}