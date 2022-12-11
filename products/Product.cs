using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3.products
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int iD, string name, int price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }

        public Product(string name)
        {
            Name = name;
        }
    }
}
