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

               
        public Peca Pecasnotab(int lines, int colums)
        {
        return  PecasMatriz[lines, colums];
        }

    }
}
