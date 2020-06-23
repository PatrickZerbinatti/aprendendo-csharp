using System;
using ExXadrez.Tabuleiro;
using ExXadrez.Tabuleiro.Enum;

namespace ExXadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tab_Class tab)
        {
            for (int i = 0; i < tab.Linha; i++)
            {
                for (int j = 0; j < tab.Coluna; j++)
                {
                    Peca peca = tab.Peca(i, j);

                    if (peca == null){
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(peca + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
