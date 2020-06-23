using ExXadrez.Tabuleiro;
using ExXadrez.Tabuleiro.Enum;

namespace ExXadrez.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tab_Class Tab { get; set; }

        public Peca(Tab_Class tab, Cor cor)
        {
            Cor = cor;
            Tab = tab;
        }
        public void IncrementarMovimentos()
        {
            QteMovimentos++;
        }

    }
}
