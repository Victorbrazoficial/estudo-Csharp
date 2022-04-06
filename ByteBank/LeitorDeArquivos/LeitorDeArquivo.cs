using System;
using System.IO;

namespace ByteBank.LeitorDeArquivos
{
    internal class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            throw new FileNotFoundException();

            Console.WriteLine("Abrindo Arquivo.");
        }

        public string LerProximaPagina()
        {
            Console.WriteLine("Lendo Linha.");

            //throw new IOException();

            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando Arquivo.");
        }
    }
}
