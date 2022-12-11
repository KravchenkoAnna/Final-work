using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.accountFor
{
    class Transaction
    {
        public int Amount { get; }
        public DateTime Date { get; }

        public Transaction(int money, DateTime now)
        {
            Amount = money;
            Date = now;
        }

        
    }
}
