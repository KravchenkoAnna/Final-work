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
            UIs.Add(new CancelClass());
        }

        private void Menu()
        {
            for (int i = 0; i < UIs.Count; i++)
            {
                Console.WriteLine(UIs[i].SelectAction());
            }
        }

        private int Action()
        {            
            int action = Convert.ToInt32(Console.ReadLine());
            UIs[action].Action();
            return action;
        }

        public void Run(string yourID, int money)
        {
            TheAccount.FillBalance(yourID, money);
            Console.WriteLine("Balance is " + TheAccount.Balance);
            Console.WriteLine("Select action:");
            int i = 0;
            int quantity = db.Products.Count;
            
            while (i < quantity)
            {               
                Menu();
                int action = Action();                
                if (action == 3)
                {
                    break;
                }
                i++;
            }

            
        }

    }
}
