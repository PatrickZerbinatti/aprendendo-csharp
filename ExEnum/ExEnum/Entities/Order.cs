using System;
using System.Collections.Generic;
using System.Text;
using ExEnum.Entities.Enum;

namespace ExEnum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem orderItem in Items)
            {
                total += orderItem.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\nORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items: ");

            foreach (OrderItem orderItem in Items)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2"));
            return sb.ToString();
        }
    }
}
