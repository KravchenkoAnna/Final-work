using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.accountFor;

namespace Lab3.products
{
    class BuyProduct : IProductInterface
    {
        public PseudoDataBase DB { get; set; }
        public Account User { get; set; }
        public BuyProduct(PseudoDataBase db, Account user)
        {
            DB = db;
            User = user;
        }
        public string SelectAction()
        {
            return "2 - buy product";
        }
        public void Action()
        {
            Console.WriteLine("Enter name of product you want to buy:");
            string name = Console.ReadLine();                        
            User.allTransactions.Add(new Transaction(-DB.ReturnPrice(name), DateTime.Now));
            Console.WriteLine(User.Owner + "`s balance is " + User.Balance);
            DB.Histories.Add(new History(name));
        }

        
    }
}
