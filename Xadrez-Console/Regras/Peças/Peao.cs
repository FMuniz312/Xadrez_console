using Tabuleiro;

namespace RegrasPeças
{
    class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiros tabuleiros) : base(cor, tabuleiros)
        {


        }

        public override string ToString()
        {
            return "P";
        }
    }
}

