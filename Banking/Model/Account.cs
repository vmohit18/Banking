/*
 Create an abstract class named Account with the following properties:

accountNumber (int)
transactionList (a list of Transaction class)
balance (double)
openingDate (Datetime)

Define the following methods:
deposit: Add a credit transaction to the transaction list for each deposit.
getAccountDetails: Returns a string with all the account details.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Banking.Model
{
    internal abstract class Account
    {
        public int AccountNumber { get; set; }
        public List<Transaction>? TransactionList { get; set; }
        public double Balance { get; set; }
        public DateTime OpeningDate { get; set; }
        public abstract void Deposit(double amount);
        public abstract string GetAccountDetails();
    }
}