using ExInterface.Entities;
using ExInterface.Services;
using System;
using System.Globalization;

namespace ExInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberOfQuotes = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);

            Payment payment = new Payment(numberOfQuotes, new Paypal());

            payment.PaymentProcess(contract);

            Console.WriteLine(contract);
        }
    }
}
