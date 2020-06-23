using ExXadrez.Tabuleiro;
using ExXadrez.Tabuleiro.Enum;
using System;

namespace ExXadrez.Xadrez
{
    class PartidaDeXadrez
    {
        public Tab_Class Tab { get; private set; }
        public bool Terminada { get; set; }
        private int turno;
        private Cor jogadorAtual;
        

        public PartidaDeXadrez()
        {
            Tab = new Tab_Class(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = Tab.RetirarPeca(origem);
            peca.IncrementarMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(peca, destino);
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Tabuleiro.Enum.Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());


            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Tabuleiro.Enum.Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Tabuleiro.Enum.Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());

        }
    }
}
