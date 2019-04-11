using RegrasPeças;
using System;
using Tabuleiro;
using RegrasPeças;
using Regras;
namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();
                
                Tela.ImprimirTabuleiro(partidaDeXadrez.tab);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
