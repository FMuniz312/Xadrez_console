using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Posicao
    {
        public int Lines { get; set; }
        public int Colums { get; set; }

        public Posicao(int lines, int colums)
        {
            Lines = lines;
            Colums = colums;
        }

        public override string ToString()
        {
            return Lines + "," + Colums;
        }

    }
}
