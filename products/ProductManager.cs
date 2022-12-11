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
        public ProductManager()
        {           
            UIs = new List<IProductInterface>();
            UIs.Add(new ShowProducts(db));
            UIs.Add(new AddProduct(db));
            UIs.Add(new BuyProduct(db));
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

        public void Run()
        {
            Console.WriteLine("Select action:");
            int i = 0;
            while (i < /*db.Products.Count*/3)
            {                
                Menu();
                Action();
                i++;
            }

            
        }

    }
}
