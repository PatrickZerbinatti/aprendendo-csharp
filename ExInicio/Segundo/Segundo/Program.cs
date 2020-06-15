using System;
using System.Globalization;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, x, y, z, a, b, c, aux;
            string[] vetorPica;

            int count = 0;

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();
           
            aux = Console.ReadLine();

            vetorPica = aux.Split(' ');

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            for (count = 0;  count < vetorPica.Length; count++){
                Console.WriteLine(vetorPica[count]);
            }
        }
    }
}
