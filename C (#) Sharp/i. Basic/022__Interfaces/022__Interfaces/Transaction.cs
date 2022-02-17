using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _022__Interfaces
{
    class Transaction
    {
        private string tCode;
        private string tDate;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            tDate = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            tDate = d;
            amount = a;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void ShowTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", tDate);
            Console.WriteLine("Amount: {0}", GetAmount());
        }
    }
}
