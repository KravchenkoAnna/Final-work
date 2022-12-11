using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.products
{
    class AddProduct : IProductInterface
    {
        public PseudoDataBase DB { get; set; }

        public AddProduct(PseudoDataBase db)
        {
            DB = db;
        }

        public string SelectAction()
        {
            return "1 - add product";
        }
        public void Action()
        {
            Console.WriteLine("Enter name of product you want to add:");
            string name = Console.ReadLine();
            DB.Products.Add(new Product(name));                       
        }

       
    }
}
