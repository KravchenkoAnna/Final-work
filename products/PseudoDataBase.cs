using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.products
{
    class PseudoDataBase
    {
        public List<Product> Products { get; set; }
        public List<History> Histories { get; set; }

        public PseudoDataBase()
        {
            Products = new List<Product>
            {
                new Product(0, "Red Car", 100),
                new Product(1, "Blue Car", 300),
                new Product(2, "Yellow Car", 500),
                new Product(3, "Grey Car", 50),
                new Product(4, "Pink Car", 1000),

            };
            Histories = new List<History>();
        }

         public int ReturnPrice(string name)
         {
            foreach (var item in Products)
            {
                if(item.Name == name)
                {
                    return item.Price;
                }
            }
            return 0;
         }
    }
}
