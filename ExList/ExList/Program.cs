using System;
using System.Collections.Generic;

namespace ExList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();
            int id;

            Console.Write("Quantos empregados serão registrados?");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Empregado Nº" + (i + 1));

                Console.Write("ID:");
                id = int.Parse(Console.ReadLine());

                if (lista.Find(x => x.Id == id) == null)
                {

                    Console.Write("Nome:");
                    string nome = Console.ReadLine();

                    Console.Write("Salario:");
                    double sal = double.Parse(Console.ReadLine());

                    lista.Add(new Funcionario(id, nome, sal));
                }
                else
                {
                    Console.WriteLine("Este ID ja existe!");
                    i--;
                }
            }

            Console.Write("Digite o ID do funcionario que recebera um aumento:");
            id = int.Parse(Console.ReadLine());

            Funcionario funcAux = lista.Find(x => x.Id == id);

            if (funcAux != null)
            {
                Console.Write("Digite a porcentagem do aumento:");
                funcAux.AumentarSalario( double.Parse(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine("Esse ID não existe!");
            }


            Console.WriteLine("Lista atualizada de funcionarios:");

            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func);
            }
        }
    }
}
