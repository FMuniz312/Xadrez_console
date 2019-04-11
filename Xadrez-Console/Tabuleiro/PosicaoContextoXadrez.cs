using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class PosicaoContextoXadrez
    {
        public char Colums { get; set; }
        public int Lines { get; set; }

        public PosicaoContextoXadrez(char colums, int lines)
        {
            Colums = colums;
            Lines = lines;
        }

        public Posicao Toposition() // Transforma em coordenadas de xadrez
        {
            return new Posicao(8 - Lines, Colums - 'a');
        }

        public override string ToString()
        {
            return "" + Lines + Colums;
        }
    }
}
