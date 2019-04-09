using RegrasPeças;
using System;
using Tabuleiro;
namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoContextoXadrez posicaoContextoXadrez = new PosicaoContextoXadrez('a', 2);

            Console.WriteLine(posicaoContextoXadrez);

            Console.WriteLine(posicaoContextoXadrez.Toposition());

        }
    }
}
