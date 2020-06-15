using System;
using System.Globalization;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, aux, cor;
            int quartos,idade;
            double preco,alt;
            string[] vetor;

            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
            aux = Console.ReadLine();

            vetor = aux.Split(' ');

            cor =  vetor[0];
            idade = int.Parse(vetor[1]);
            alt = double.Parse(vetor[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(cor);
            Console.WriteLine(idade);
            Console.WriteLine(alt.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
