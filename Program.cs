using Lab3.accountFor;
using Lab3.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input your accounts ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Input the fulfilling amount: ");
            int money = Convert.ToInt32(Console.ReadLine());
            
            new ProductManager(name).Run(id, money);

        }
    }
}
