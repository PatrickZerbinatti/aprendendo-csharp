using System;

namespace ExBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.Write("Entre o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char aux = char.Parse(Console.ReadLine());

            if (aux == 's' || aux == 'S'){
                Console.Write("Entre o valor de deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                contaBancaria = new ContaBancaria(conta, nome, deposito);
            }
            else
            {
                contaBancaria = new ContaBancaria(conta, nome);
            }

            Console.WriteLine(contaBancaria);

            Console.Write("Entre um valor para deposito: ");
            contaBancaria.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine(contaBancaria);

            Console.Write("Entre um valor para saque: ");
            contaBancaria.Saque( double.Parse(Console.ReadLine()));

            Console.WriteLine(contaBancaria);

        }
    }
}
