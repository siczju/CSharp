using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio.Entities.Exceptions;

namespace Exercicio.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }
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
                throw new WithdrawExceedsLimitException("Exception due to exceeds the limit of withdraw");

            if (amount > Balance)
                throw new NotEnoughBalanceToWithdrawException("Exception due to balance not being enough to withdraw");

            Balance -= amount;
        }

    }
}
