
using Tabuleiro;
namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tabuleiro = new Tabuleiros(8, 8);

            Tela.ImprimirTabuleiro(tabuleiro);
            
        }
    }
}
