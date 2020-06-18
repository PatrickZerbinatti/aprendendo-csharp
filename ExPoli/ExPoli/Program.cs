using ExPoli.Entities;
using System;
using System.Collections.Generic;

namespace ExPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char cui = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (cui == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (cui == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\n PRICE TAGS:");
            foreach (Product item in products)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
