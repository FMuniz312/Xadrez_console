using Tabuleiro;

namespace RegrasPeças
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiros tabuleiros) : base(cor, tabuleiros)
        {


        }

        public override string ToString()
        {
            return "T";
        }
    }
}
