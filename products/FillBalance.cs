using Lab3.accountFor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.products
{
    class FillBalance : IProductInterface
    {
        public PseudoDataBase DB { get; set; }
        public Account User { get; set; }
        public FillBalance(PseudoDataBase db, Account user)
        {
            DB = db;
            User = user;
        }

        public string SelectAction()
        {
            return "1 - fill balance";
        }
        public void Action()
        {
            Console.WriteLine("Input the fulfilling amount: ");
            int money = Convert.ToInt32(Console.ReadLine());
            User.allTransactions.Add(new Transaction(money, DateTime.Now));
           
        }

       
    }
}
