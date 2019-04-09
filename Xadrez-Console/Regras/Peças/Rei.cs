using Tabuleiro;

namespace RegrasPeças
{
    class Rei : Peca
    {
public  Rei ( Cor cor, Tabuleiros tabuleiros) : base (cor,tabuleiros)
        {


        }

        public override string ToString()
        {
            return "R";
        }
    }
}
