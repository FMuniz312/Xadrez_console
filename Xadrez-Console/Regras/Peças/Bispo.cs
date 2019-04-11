using Tabuleiro;

namespace RegrasPeças
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiros tabuleiros) : base(cor, tabuleiros)
        {


        }

        public override string ToString()
        {
            return "B";
        }
    }
}
