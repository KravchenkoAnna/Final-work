using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Lab3.products
{
    class CancelClass : IProductInterface
    {
        public void Action()
        {
            Console.WriteLine("Goodbye!");
        }

        public string SelectAction()
        {
            return "3 - exit";
        }


        
    }
}
