using Lab3.accountFor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.products
{
    class ProductManager
    {
        private List<IProductInterface> UIs { get; set; }
        private PseudoDataBase db = new PseudoDataBase();
        public Account TheAccount { get; set; }
        public ProductManager(string name)
        {           
            UIs = new List<IProductInterface>();
            TheAccount = new Account(name);
            UIs.Add(new ShowProducts(db));
            UIs.Add(new AddProduct(db, TheAccount));
            UIs.Add(new BuyProduct(db, TheAccount));
        }

        private void Menu()
        {
            for (int i = 0; i < UIs.Count; i++)
            {
                Console.WriteLine(UIs[i].SelectAction());
            }
        }

        private void Action()
        {            
            int action = Convert.ToInt32(Console.ReadLine());
            UIs[action].Action();
        }

        public void Run(string yourID, int money)
        {
            TheAccount.FillBalance(yourID, money);
            Console.WriteLine("Balance is " + TheAccount.Balance);
            Console.WriteLine("Select action:");
            int i = 0;
            while (i < db.Products.Count)
            {                
                Menu();
                Action();
                i++;
            }

            
        }

    }
}
