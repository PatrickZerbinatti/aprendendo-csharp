﻿using ExException.Entities.Exceptions;

namespace ExException.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExeception("Withdraw error: The amount exceeds withdraw limit.");
            }
            else if (Balance < amount)
            {
                throw new DomainExeception("Withdraw error: Not enough balance");
            }

            Balance -= amount;
        }

    }
}
