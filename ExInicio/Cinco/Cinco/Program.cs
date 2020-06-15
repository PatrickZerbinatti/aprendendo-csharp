using System;

namespace Cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else if (n < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
