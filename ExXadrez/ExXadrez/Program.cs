using System;
using ExXadrez.Tabuleiro;

namespace ExXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tab_Class tab_Class = new Tab_Class(8, 8);

            Tela.imprimirTabuleiro(tab_Class);
        }
    }
}
