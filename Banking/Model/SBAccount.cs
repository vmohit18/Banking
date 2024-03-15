/*
 Create a class as a subclass of Account with the following additional properties:
minBalance (double)
Implement the following method:
withdraw: This method accepts an amount and throws an InsufficientBalanceException if the Balance is not available and adds a debit transaction to the transaction list for each withdrawal.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Model
{
    internal class SBAccount : Account
    {
        public double MinBalance { get; set; }
        public override void Deposit(double amount)
        {
            TransactionList.Add(new Transaction { Date = DateTime.Now, Type = TransactionType.Credit, Amount = amount });
            Balance += amount;
        }
        public override string GetAccountDetails()
        {
            return "Account Number: " + AccountNumber + "\n" +
                "Balance: " + Balance + "\n" +
                "Opening Date: " + OpeningDate + "\n" +
                "Minimum Balance: " + MinBalance;
        }
        public void Withdraw(double amount)
        {
            if (Balance - amount < MinBalance)
            {
                throw new InsufficientBalanceException("Insufficient Balance");
            }
            TransactionList.Add(new Transaction { Date = DateTime.Now, Type = TransactionType.Debit, Amount = amount });
            Balance -= amount;
        }
    }
}
