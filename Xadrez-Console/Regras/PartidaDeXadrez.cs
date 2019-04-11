using Tabuleiro;
using RegrasPeças;
using Xadrez_Console;


namespace Regras
{
    class PartidaDeXadrez
    {
        public Tabuleiros tab { get; private set; }
        private int turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiros(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branco;
            ColocarPeçasINICIO();
        }

        public  void ExecutaMovimento(Posicao inicial, Posicao final)
        {
            Peca p = tab.RetirarPeca(inicial); //Segurando a peca no objeto P para colocar na nova posição
            p.incrementamov();
            Peca pecaCap = tab.RetirarPeca(final);//Capturando peca caso haja
            tab.colocarpeca(p, final);

        }

        private void ColocarPeçasINICIO()
        {
            //Peças Brancas sendo colocadas
            tab.colocarpeca(new Torre(Cor.Branco, tab), new PosicaoContextoXadrez('a',1).Toposition()); 
            tab.colocarpeca(new Cavalo(Cor.Branco, tab), new PosicaoContextoXadrez('b', 1).Toposition());
            tab.colocarpeca(new Bispo(Cor.Branco, tab), new PosicaoContextoXadrez('c', 1).Toposition());
            tab.colocarpeca(new Rei(Cor.Branco, tab), new PosicaoContextoXadrez('d',1 ).Toposition());
            tab.colocarpeca(new Rainha(Cor.Branco, tab), new PosicaoContextoXadrez('e', 1).Toposition());
            tab.colocarpeca(new Bispo(Cor.Branco, tab), new PosicaoContextoXadrez('f', 1).Toposition());
            tab.colocarpeca(new Cavalo(Cor.Branco, tab), new PosicaoContextoXadrez('g', 1).Toposition());
            tab.colocarpeca(new Torre(Cor.Branco, tab), new PosicaoContextoXadrez('h', 1).Toposition());
            tab.colocarpeca(new Peao(Cor.Branco, tab), new PosicaoContextoXadrez('a', 2).Toposition());
            tab.colocarpeca(new Peao(Cor.Branco, tab), new PosicaoContextoXadrez('b', 2).Toposition());
            tab.colocarpeca(new Peao(Cor.Branco, tab), new PosicaoContextoXadrez('c', 2).Toposition());
            tab.colocarpeca(new Peao(Cor.Branco, tab), new PosicaoContextoXadrez('d', 2).Toposition());
            tab.colocarpeca(new Peao(Cor.Branco, tab), new PosicaoContextoXadrez('e', 2).Toposition());
            tab.colocarpeca(new Peao(Cor.Branco, tab), new PosicaoContextoXadrez('f', 2).Toposition());
            tab.colocarpeca(new Peao(Cor.Branco, tab), new PosicaoContextoXadrez('g', 2).Toposition());
            tab.colocarpeca(new Peao(Cor.Branco, tab), new PosicaoContextoXadrez('h', 2).Toposition());

            //--------------------------------------------------------------------------------------------/

            //Peças Pretas sendo colocadas
            tab.colocarpeca(new Torre(Cor.Preto, tab), new PosicaoContextoXadrez('a', 8).Toposition());
            tab.colocarpeca(new Cavalo(Cor.Preto, tab), new PosicaoContextoXadrez('b', 8).Toposition());
            tab.colocarpeca(new Bispo(Cor.Preto, tab), new PosicaoContextoXadrez('c', 8).Toposition());
            tab.colocarpeca(new Rei(Cor.Preto, tab), new PosicaoContextoXadrez('d', 8).Toposition());
            tab.colocarpeca(new Rainha(Cor.Preto, tab), new PosicaoContextoXadrez('e', 8).Toposition());
            tab.colocarpeca(new Bispo(Cor.Preto, tab), new PosicaoContextoXadrez('f', 8).Toposition());
            tab.colocarpeca(new Cavalo(Cor.Preto, tab), new PosicaoContextoXadrez('g', 8).Toposition());
            tab.colocarpeca(new Torre(Cor.Preto, tab), new PosicaoContextoXadrez('h', 8).Toposition());
            tab.colocarpeca(new Peao(Cor.Preto, tab), new PosicaoContextoXadrez('a', 7).Toposition());
            tab.colocarpeca(new Peao(Cor.Preto, tab), new PosicaoContextoXadrez('b', 7).Toposition());
            tab.colocarpeca(new Peao(Cor.Preto, tab), new PosicaoContextoXadrez('c', 7).Toposition());
            tab.colocarpeca(new Peao(Cor.Preto, tab), new PosicaoContextoXadrez('d', 7).Toposition());
            tab.colocarpeca(new Peao(Cor.Preto, tab), new PosicaoContextoXadrez('e', 7).Toposition());
            tab.colocarpeca(new Peao(Cor.Preto, tab), new PosicaoContextoXadrez('f', 7).Toposition());
            tab.colocarpeca(new Peao(Cor.Preto, tab), new PosicaoContextoXadrez('g', 7).Toposition());
            tab.colocarpeca(new Peao(Cor.Preto, tab), new PosicaoContextoXadrez('h', 7).Toposition());
            //--------------------------------------------------------------------------------------------/

        }




    }
}
