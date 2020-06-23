using System;
using ExXadrez.Tabuleiro;
using ExXadrez.Tabuleiro.Except;
using ExXadrez.Xadrez;

namespace ExXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tab_Class tab_Class = new Tab_Class(8, 8);

                tab_Class.ColocarPeca(new Torre(tab_Class, Tabuleiro.Enum.Cor.Preta), new Posicao(0, 0));
                tab_Class.ColocarPeca(new Torre(tab_Class, Tabuleiro.Enum.Cor.Preta), new Posicao(1, 3));
                tab_Class.ColocarPeca(new Rei(tab_Class, Tabuleiro.Enum.Cor.Preta), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab_Class);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
