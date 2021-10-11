using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // price of groceries Problem 

            // Creation of Hash Table 
            Dictionary<string, decimal> Menu = new Dictionary<string, decimal>();

            // Insert into Hash Table
            Menu.Add("apple", 0.67m);
            Menu.Add("milk", 1.49m);
            Menu.Add("avocado", 1.49m);

            //Loop Through the hash table 

            foreach (var item in Menu)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }

            Console.WriteLine("-------------------------");

            //Check Voter Problem

            Dictionary<string, bool> Voted = new Dictionary<string, bool>();

            Voted.Add("mahmoud", true);
            Voted.Add("Ali", false);
            Voted.Add("Asd", true);

            if(Voted.ContainsKey("Ahmed"))
            {
                Console.WriteLine("Kick him out !!!");
            }
            else
            {
                Voted.Add("Ahmed", true);
                Console.WriteLine("Let him Vote.");
            }
        }
    }
}
