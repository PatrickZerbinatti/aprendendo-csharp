using System;
using ExXadrez.Tabuleiro;
using ExXadrez.Xadrez;

namespace ExXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tab_Class tab_Class = new Tab_Class(8, 8);

            tab_Class.colocarPeca(new Torre(tab_Class,Tabuleiro.Enum.Cor.Preta), new Posicao(0, 0));
            tab_Class.colocarPeca(new Torre(tab_Class, Tabuleiro.Enum.Cor.Preta), new Posicao(1, 3));
            tab_Class.colocarPeca(new Rei(tab_Class, Tabuleiro.Enum.Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab_Class);
        }
    }
}
