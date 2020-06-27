using System;
using System.Collections.Generic;
using System.Text;

namespace ExInterface.Services
{
    class Paypal : IPaymentService
    {
        public double Tax(double amount , int quote)
        {
            amount += amount * 0.01 * quote;

            return amount += amount * 0.02;

        }

    }
}
