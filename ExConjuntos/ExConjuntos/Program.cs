using ExConjuntos.Entities;
using System;
using System.Collections.Generic;

namespace ExConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Aluno> alunos = new HashSet<Aluno>();

            Console.Write("How many students for course A?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                alunos.Add(new Aluno(int.Parse(Console.ReadLine())));
            }

            Console.Write("How many students for course B?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                alunos.Add(new Aluno(int.Parse(Console.ReadLine())));
            }

            Console.Write("How many students for course C?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                alunos.Add(new Aluno(int.Parse(Console.ReadLine())));
            }

            Console.WriteLine("Total de estudantes: " + alunos.Count); 
        }
    }
}
