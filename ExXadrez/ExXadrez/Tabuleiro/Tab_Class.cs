
namespace ExXadrez.Tabuleiro
{
    class Tab_Class
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Peca[,] pecas;

        public Tab_Class(int linha, int colunas)
        {
            Linha = linha;
            Coluna = colunas;

            pecas = new Peca[linha, colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
