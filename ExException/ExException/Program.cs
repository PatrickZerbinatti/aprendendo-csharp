using ExException.Entities;
using ExException.Entities.Exceptions;
using System;

namespace ExException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine()));
                Console.Write("New balance: ");
                Console.WriteLine(account.Balance.ToString("F2"));
            }
            catch (DomainExeception e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InvalidCastException)
            {
                Console.WriteLine("InvalidCastException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
