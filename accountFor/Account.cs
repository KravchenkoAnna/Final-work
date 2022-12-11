using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab3.accountFor
{
    class Account
    {
        public List<Transaction> allTransactions = new List<Transaction>();

        private static int accountNumberSeed = 100;
        public string ID { get; }
        public string Owner { get; set; }
        public int Balance
        {
            get
            {
                int balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        public Account(string owner)
        {
            Owner = owner;

            ID = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        private bool Verify(string number)
        {
            if (string.Equals(number, ID))
            {
                return true;
            }
            else
            {
                throw new Exception("This is not your accounts ID");
            }
        }

        public void FillBalance(string yourID, int money)
        {
            if (Verify(yourID))
            {
                Console.Write(Owner + " ");
                allTransactions.Add(new Transaction(money, DateTime.Now));
            }
        }




    }
}
