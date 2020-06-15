using System;

namespace ExClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa prim, seg;

            prim = new Pessoa();
            seg = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa.");
            prim.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da primeira pessoa.");
            prim.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa.");
            seg.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa.");
            seg.idade = int.Parse(Console.ReadLine());

            if (prim.idade >= seg.idade)
            {
                Console.WriteLine("A pessoa mais velha é: "+ prim.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: "+ seg.nome);
            }
        }
    }
}
