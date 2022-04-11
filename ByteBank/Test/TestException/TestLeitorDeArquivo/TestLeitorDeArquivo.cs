using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.LeitorDeArquivos;

namespace ByteBank.Test.TestException.TestLeitorDeArquivo
{
    public class TestLeitorDeArquivo
    {
        public static void TestMetodoDispose()
        {
            try
            {
                using (LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo("Arquivo.txt"))
                {
                    leitorDeArquivo.LerProximaPagina();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("CATCH DO METODO");
            }
        }
    }
}
