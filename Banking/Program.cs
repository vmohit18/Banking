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
            sb.Deposit(900.5);
            sb.Withdraw(500.25);
            Console.WriteLine(sb.GetAccountDetails());

            Console.WriteLine("#################### Transaction Details #########################");
            foreach (Transaction t in sb.TransactionList)
            {
                Console.WriteLine("Date: " + t.Date + " Type: " + t.Type + " Amount: " + t.Amount);
            }
            Console.WriteLine("");
            Console.WriteLine("############################## Fixed Deposit Summary ####################################");
            
            /*
             create a new FDAccount object and call the Deposit and Withdraw methods to test the implementation.
             Call the GetMaturityAmount and GetTenure methods to display the maturity amount and tenure.
             */
         
            FDAccount fd = new FDAccount();
            fd.AccountNumber = 102;
            fd.TransactionList = new List<Transaction>();
            fd.Balance = 10000;
            fd.OpeningDate = DateTime.Now;
            fd.MaturityDate = DateTime.Now.AddMonths(12);
            fd.InterestRate = 8;
            fd.Deposit(10000);
            Console.WriteLine(fd.GetAccountDetails());
            Console.WriteLine("Maturity Amount: " + fd.GetMaturityAmount());
            Console.WriteLine("Tenure in months: " + fd.GetTenure());
        }

    }
}