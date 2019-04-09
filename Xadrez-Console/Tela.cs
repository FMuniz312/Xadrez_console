using Tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiros tabuleiros)
        {
            for (int i = 0; i < tabuleiros.Lines; i++)
            {
                for (int j = 0; j < tabuleiros.Colums; j++)
                {
                    if (tabuleiros.Pecasnotab(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.Write(tabuleiros.Pecasnotab(i, j) + " ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}
