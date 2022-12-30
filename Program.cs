using Lab3.accountFor;
using Lab3.products;
using System.Text.Json;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input your name: ");
            string name = Console.ReadLine();
          
            ProductManager pm = new ProductManager(name);
            pm.Run();
            
            string fileName = "dataBase.json";
            string jsonString = JsonSerializer.Serialize(pm);
            File.WriteAllText(fileName, jsonString);
            
            Console.WriteLine(File.ReadAllText(fileName));
            
        }
    }
}
