using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.products
{
    class History
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public History(string productName)
        {
            ProductName = productName;
        }
        public History(int productPrice)
        {
            ProductPrice = productPrice;
        }

    }
}
