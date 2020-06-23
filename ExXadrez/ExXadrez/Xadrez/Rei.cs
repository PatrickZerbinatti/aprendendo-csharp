using ExXadrez.Tabuleiro;
using ExXadrez.Tabuleiro.Enum;

namespace ExXadrez.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tab_Class tab_Class, Cor cor) : base(tab_Class, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tab.Peca(posicao);

            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linha, Tab.Coluna];

            Posicao posicao = new Posicao(0, 0);

            //norte

            posicao.Definirvalor(posicao.Linha - 1, posicao.Coluna);
            if (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //nordeste 

            posicao.Definirvalor(posicao.Linha - 1, posicao.Coluna + 1);
            if (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //leste

            posicao.Definirvalor(posicao.Linha, posicao.Coluna + 1);
            if (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //sudeste

            posicao.Definirvalor(posicao.Linha + 1, posicao.Coluna + 1);
            if (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //sul

            posicao.Definirvalor(posicao.Linha + 1, posicao.Coluna);
            if (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //sudoeste

            posicao.Definirvalor(posicao.Linha + 1, posicao.Coluna - 1);
            if (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //oeste

            posicao.Definirvalor(posicao.Linha, posicao.Coluna - 1);
            if (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //noroeste

            posicao.Definirvalor(posicao.Linha - 1, posicao.Coluna - 1);
            if (Tab.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            return mat;
        }
    }
}
