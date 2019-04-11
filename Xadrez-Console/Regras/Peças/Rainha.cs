using Tabuleiro;

namespace RegrasPeças
{
    class Rainha : Peca
    {
        public Rainha(Cor cor, Tabuleiros tabuleiros) : base(cor, tabuleiros)
        {


        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
