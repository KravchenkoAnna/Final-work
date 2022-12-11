using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.products
{
    class ShowProducts : IProductInterface
    {
        public PseudoDataBase DB { get; set; }
        public ShowProducts(PseudoDataBase db)
        {
            DB = db;
        }
        public string SelectAction()
        {
            return "0 - show products";
        }
        public void Action()
        {
            Console.WriteLine("Products:");
            Console.Write("|");
            for (int i = 0; i < DB.Products.Count; i++)
            {
                Console.Write(DB.Products[i].Name + " for " + DB.Products[i].Price + "| ");
            }
            
            Console.WriteLine();
        }

        
    }
}
