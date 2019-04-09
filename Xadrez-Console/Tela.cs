using System;
using Tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiros tabuleiros)
        {
            for (int i = 0; i < tabuleiros.Lines; i++) //Percorrendo Linhas
            {
                System.Console.Write(8 - i + " ");//Numeros de direção do tabuleiro
                for (int j = 0; j < tabuleiros.Colums; j++)//Percorrendo Colunas
                {
                    if (tabuleiros.Pecasnotab(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPreca(tabuleiros.Pecasnotab(i, j));
                        
                    }

                }

                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");//Letras de direção do tabuleiro
        }
        public static void ImprimirPreca(Peca peca)
        {
            if(peca.Color == Cor.Branco)
            {
                System.Console.Write(peca+" ");
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peca+ " ");
                Console.ForegroundColor = aux;
            }

        }
    }
}
