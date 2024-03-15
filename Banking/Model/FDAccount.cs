/*
 Create the class as a subclass of Account with the following additional properties:

maturityDate of datetime datatype
interestRate as a double
Implement the following methods:
getTenure: Returns the tenure in months.
getMaturityAmount: Returns the maturity amount.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Model
{
    internal class FDAccount : Account
    {
        public DateTime MaturityDate { get; set; }
        public double InterestRate { get; set; }
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
                "Maturity Date: " + MaturityDate + "\n" +
                "Interest Rate: " + InterestRate;
        }
        public int GetTenure()
        {
            return (MaturityDate.Month - OpeningDate.Month) + 12 * (MaturityDate.Year - OpeningDate.Year);
        }
        public double GetMaturityAmount()
        {
            return Balance + (Balance * InterestRate * GetTenure() / 100 / 12);
        }
    }
}