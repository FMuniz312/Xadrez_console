 using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Position { get; set; }
        public Cor Color { get; protected set; }
        public Tabuleiros Tabposition { get; protected set; }
        public int QntDeMovimentos { get; protected set; }

        public Peca(Posicao position, Cor color, Tabuleiros tabposition, int qntDeMovimentos)
        {
            Position = position;
            Color = color;
            Tabposition = tabposition;
            QntDeMovimentos = qntDeMovimentos;
        }
    }
}
