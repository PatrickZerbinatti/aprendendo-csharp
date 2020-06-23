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
            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('a', 1);

            Console.WriteLine(posicaoXadrez);

            Console.WriteLine(posicaoXadrez.ToPosicao());
        }
    }
}
