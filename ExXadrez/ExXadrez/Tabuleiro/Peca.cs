using ExXadrez.Tabuleiro;
using ExXadrez.Tabuleiro.Enum;

namespace ExXadrez.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tab_Class Tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tab_Class tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
        }


    }
}
