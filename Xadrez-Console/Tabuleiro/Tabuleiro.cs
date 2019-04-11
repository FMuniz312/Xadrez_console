using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Tabuleiros
    {
        public int Lines { get; set; }
        public int Colums { get; set; }
        private Peca[,] PecasMatriz;

        public Tabuleiros(int lines, int colums)
        {
            Lines = lines;
            Colums = colums;
            PecasMatriz = new Peca[Lines, Colums];
                                                         
       }

               
        public Peca Pecasnotab(Posicao posicao) // Retorna a peca na posicao passada
        {
            return PecasMatriz[posicao.Lines, posicao.Colums]; 
                }
        public Peca Pecasnotab(int lines, int colums) // Retorna a peca na posicao passada
        {
        return  PecasMatriz[lines, colums];
        }

        public void colocarpeca (Peca peca, Posicao posicao) //Coloca uma pesa no tabuleiro
        {
            PecasMatriz[posicao.Lines,posicao.Colums] = peca;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (Pecasnotab(posicao) == null)
            {
                return null;
            }
            Peca auxiliar = Pecasnotab(posicao);
            auxiliar.Position = null;
            PecasMatriz[posicao.Lines, posicao.Colums] = null;
            return auxiliar;
        }

    }
}
