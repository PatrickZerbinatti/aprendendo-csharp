using System;

namespace ExStatic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dolar?");
            ConversorDeMoeda.Cota = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dolares deseja comprar?");
            ConversorDeMoeda.Qtd = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = "+ConversorDeMoeda.Valor());
        }
    }
}
