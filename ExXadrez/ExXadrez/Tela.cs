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
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Coluna; j++)
                {
                    Peca peca = tab.Peca(i, j);

                    if (peca == null){
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;

            }
        }
    }
}
