using System;

namespace ExVetor
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] estudantes = new Estudante[10];

            Console.WriteLine("Digite o numero de estudantes a alugar quartos:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do estudante");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email do estudante");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o quarto do estudante");
                int quarto = int.Parse(Console.ReadLine());

                estudantes[quarto] = new Estudante(nome, email, quarto);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < estudantes.Length; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine(estudantes[i]);
                }
            }
        }
    }
}
