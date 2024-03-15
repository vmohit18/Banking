/*
 Create a Transaction class with the following properties:
date of datetime datatype
type as an enum with 'debit' and 'credit'
amount as a double
All the properties should have a public get and set method.
All the property names should be camel case.
 */

using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Model
{
    internal class Transaction
    {
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public double Amount { get; set; }
    }
    public enum TransactionType
    {
        Debit,
        Credit
    }
}

