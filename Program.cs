using Lab3.accountFor;
using Lab3.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

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

            ProductManager pm = new ProductManager(name);
            pm.Run(id, money);

            string fileName = "dataBase.json";
            string jsonString = JsonSerializer.Serialize(pm);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));

        }
    }
}
