using System;
using System.Collections.Generic;
using System.Text;

namespace ExInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> installments = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public override string ToString()
        {
            string result;
            result = "\nInstallments: ";

            foreach (Installment item in installments)
            {
                result += "\n" + item;
            }

            return result;
        }
    }
}
