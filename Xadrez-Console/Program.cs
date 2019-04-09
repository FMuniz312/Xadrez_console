using RegrasPeças;
using System;
using Tabuleiro;
namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiros tabuleiro = new Tabuleiros(8, 8);
                tabuleiro.colocarpeca(new Rei(Cor.Preto, tabuleiro), new Posicao(0, 0));
                tabuleiro.colocarpeca(new Torre(Cor.Branco, tabuleiro), new Posicao(1, 0));
                tabuleiro.colocarpeca(new Torre(Cor.Preto, tabuleiro), new Posicao(2, 4));

                Tela.ImprimirTabuleiro(tabuleiro);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
