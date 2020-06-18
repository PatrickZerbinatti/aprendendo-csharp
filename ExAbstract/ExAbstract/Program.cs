using ExAbstract.Entities;
using System;
using System.Collections.Generic;

namespace ExAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payers> payers = new List<Payers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine());
                if (ic == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthCare = double.Parse(Console.ReadLine());
                    payers.Add(new Individual(name, annualIncome, healthCare));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine("\n TAXES PAID");
            double totalTax = 0.0;
            foreach (Payers payer in payers)
            {
                double tax = payer.Taxes();
                totalTax += tax;
                Console.WriteLine(payer.Name + " $ " + tax.ToString("F2"));
            }

            Console.WriteLine("TOTAL TAXES: $ " + totalTax.ToString("F2"));
        }
    }
}
