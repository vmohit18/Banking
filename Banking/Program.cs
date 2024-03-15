/*
 Create a new SBAccount object and call the Deposit and Withdraw methods to test the implementation.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Model;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount sb = new SBAccount();
            sb.AccountNumber = 101;
            sb.TransactionList = new List<Transaction>();
            sb.Balance = 1000;
            sb.OpeningDate = DateTime.Now;
            sb.MinBalance = 500;
            sb.Deposit(1000.5);
            sb.Withdraw(500.25);
            Console.WriteLine(sb.GetAccountDetails());
        }
    }
}