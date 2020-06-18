using System;
using System.Collections.Generic;
using System.Text;

namespace ExPoli.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2") + "(Customs fee: $ " + CustomsFee.ToString("F2") + ")";
        }
    }
}
