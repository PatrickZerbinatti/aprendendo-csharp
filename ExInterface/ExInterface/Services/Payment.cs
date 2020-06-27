using ExInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExInterface.Services
{
    class Payment
    {
        public int NumberOfQuotes { get; set; }

        private IPaymentService _paymentService;

        public Payment(int numberOfQuotes, IPaymentService paymentService)
        {
            NumberOfQuotes = numberOfQuotes;
            _paymentService = paymentService;
        }

        public void PaymentProcess(Contract contract)
        {
            for (int quote = 1; quote <= NumberOfQuotes; quote++)
            {
                DateTime dueDate = contract.Date.AddMonths(quote);

                double amount = contract.TotalValue / NumberOfQuotes;

                double quoteValue = _paymentService.Tax(amount, quote);

                Installment installment = new Installment(dueDate, quoteValue);

                contract.installments.Add(installment);
            }
        }
    }
}
