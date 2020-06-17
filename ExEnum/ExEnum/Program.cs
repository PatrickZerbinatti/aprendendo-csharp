using System;
using ExEnum.Entities;
using ExEnum.Entities.Enum;

namespace ExEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();


            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data");
            Console.Write("Status : ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProd = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qtdProd = int.Parse(Console.ReadLine());

                Product product = new Product(nameProd, priceProd);

                OrderItem orderItem = new OrderItem(qtdProd, priceProd, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine(order.ToString()); 

        }
    }
}
