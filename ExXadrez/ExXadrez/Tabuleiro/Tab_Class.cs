
using ExXadrez.Tabuleiro.Except;

namespace ExXadrez.Tabuleiro
{
    class Tab_Class
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Peca[,] Pecas;

        public Tab_Class(int linha, int colunas)
        {
            Linha = linha;
            Coluna = colunas;

            Pecas = new Peca[linha, colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca Peca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return Peca(posicao) != null;
        }
        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Ja existe uma peça nesta posição");
            }
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (Peca(posicao) == null)
            {
                return null;
            }
            else
            {
                Peca aux = Peca(posicao);
                aux.Posicao = null;
                Pecas[posicao.Linha, posicao.Coluna] = null;
                return aux;
            }
        }
        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha<0 || posicao.Linha>=Linha || posicao.Coluna<0 || posicao.Coluna>=Coluna)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição invalida!");
            }
        }
    }
}
