using Lab3.accountFor;
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
            Account fir = new Account("Bob");
            Console.WriteLine("Input your ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Input your money: ");
            int money = Convert.ToInt32(Console.ReadLine());
            fir.FillBalance(id, money);

            Console.WriteLine(fir.Balance);
        }
    }
}
