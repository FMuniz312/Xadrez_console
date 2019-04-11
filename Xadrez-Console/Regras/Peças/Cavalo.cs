using Tabuleiro;

namespace RegrasPeças
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiros tabuleiros) : base(cor, tabuleiros)
        {


        }

        public override string ToString()
        {
            return "C";
        }
    }
}
