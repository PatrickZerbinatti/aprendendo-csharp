using System;

namespace ExClasseRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo;
            double alt, larg;

            Console.WriteLine("Digite a Altura:");
            alt = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Largura:");
            larg = double.Parse(Console.ReadLine());

            retangulo = new Retangulo(larg, alt);

            Console.WriteLine("AREA = "+retangulo.Area().ToString("F2"));

            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2"));

            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2"));
        }
    }
}
