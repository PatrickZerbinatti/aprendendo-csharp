using ExXadrez.Tabuleiro;
using ExXadrez.Tabuleiro.Enum;

namespace ExXadrez.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tab_Class tab_Class, Cor cor) : base(tab_Class, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tab.Peca(posicao);

            return peca == null || peca.Cor != Cor;
        }
    }
}
