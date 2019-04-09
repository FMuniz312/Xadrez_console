 using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Position { get; set; }
        public Cor Color { get; protected set; }
        public Tabuleiros Tabuleiro { get; protected set; }
        public int QntDeMovimentos { get; protected set; }

        public Peca(Cor color, Tabuleiros tabuleiro)
        {
            Position = null;
            Color = color;
            Tabuleiro = tabuleiro;
            QntDeMovimentos = 0;
        }
    }
}
