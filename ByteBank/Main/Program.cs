using System;
using ByteBank.Clientes;
using ByteBank.Contas;
using ByteBank.Exceptions;
using ByteBank.LeitorDeArquivos;
using System.IO;
using ByteBank.Test.TestException.Conta.Corrente.OperacoesFinanceiras;

namespace ByteBank.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ContaCorrente.TotaldeDeContas);

            //ContaCorrente contaCorrente = new ContaCorrente(123, 456456);
            //Console.WriteLine(ContaCorrente.TotaldeDeContas);

            //try
            //{
            //metodo();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message); 
            //}


            //Console.WriteLine("ulala");

            //ContaCorrente contaCorrente = new ContaCorrente(1, 1);
            //Console.WriteLine(contaCorrente.Numero);
            //Console.WriteLine(contaCorrente.Agencia);
            //Console.WriteLine(contaCorrente.Saldo = -2);

            //try
            //{
            //ContaCorrente conta = new ContaCorrente(1454,45);
            //}
            //catch (ArgumentException e)
            //{

            //Console.WriteLine("Argumento com problema: " + e.ParamName);
            //Console.WriteLine(e.Message);
            //}


            //ContaCorrente contaCorrente03 = new ContaCorrente(123, 1235);
            //ContaCorrente conta02 = new ContaCorrente(123, 456);
            //try
            //{
            //    conta02.Depositar(100);
            //    conta02.Sacar(200);
            //    conta02.Transferir(00, contaCorrente03);
            //}
            //catch (ArgumentNullException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.ParamName);
            //    Console.WriteLine(e.StackTrace);
            //}
            //catch (SaldoInsuficienteException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Exceçao do tipo SaldoInsuficienteException");
            //    Console.WriteLine(e.StackTrace);
            //}
            //catch (OperacaoFinanceiraException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Exceçao do tipo SaldoInsuficienteException");
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine("Informações da INNER EXCEPTION.");
            //    Console.WriteLine(e.InnerException.Message);
            //    Console.WriteLine(e.InnerException.StackTrace);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}

            //Console.WriteLine(conta02.Saldo);
            //Console.WriteLine(contaCorrente03.Saldo);

            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("Teste");
            //    leitor.LerProximaPagina();  
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    leitor.Fechar();
            //}


            //try
            //{

            //using (LeitorDeArquivo leitor = new LeitorDeArquivo("arquivo.txt"))
            //{
            //    leitor.LerProximaPagina();
            //}

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("CATCH METODO MAIN");
            //}

            //ContaCorrente

            TestDeposita.DepositaValorNegativo(100);
            TestSacar.SacarValorNegativo(100);
            TestTransferir.TransferirValorNegativo(500);
        }

        public static void metodo()
        {
            try 
            {
            Dividir(1,0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Cliente cliente = null;
            Console.WriteLine(cliente.Profissao);            

        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            } 
            catch (Exception e)
            {
                throw;
            }           
        }
    }
}
    