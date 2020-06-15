using System;

namespace ExClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;
            double media;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            a.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            b.Salario = double.Parse(Console.ReadLine());

            media = (a.Salario + b.Salario) / 2.0;

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.WriteLine("Nome: "+a.Nome);
            Console.WriteLine("Salario: "+a.Salario);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.WriteLine("Nome: "+b.Nome);
            Console.WriteLine("Salario: "+b.Salario);

            Console.WriteLine("Salario médio = " + media.ToString("F2"));
        }
    }
}
