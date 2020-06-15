using System;

namespace Quarto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, final;

            a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine());

            c = int.Parse(Console.ReadLine());

            d = int.Parse(Console.ReadLine());

            final = (a * b) - (c * d);

            Console.WriteLine("DEFERENÇA = "+ final);
        }
    }
}
