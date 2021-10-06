using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        // Factorial Function 
        public static int Fact(int x)
        {
            if (x <= 1)
                return 1;
            else
                return x * Fact(x - 1);
        }

        // CountDown Function 
        public static void CountDown(int n)
        {
            if (n <= 0)
                return;
            else
            {
                Console.WriteLine(n);
                CountDown(--n);
            }
        }

        //Greating Function 

        private static void Greet(string name)
        {
            Console.WriteLine($"hello, {name}!");
            Greet2(name);
            Console.WriteLine("getting ready to say bye...");
            Bye();
        }

        private static void Greet2(string name)
        {
            Console.WriteLine($"how are you, {name}?");
        }

        private static void Bye()
        {
            Console.WriteLine("ok bye!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("factorial of 5 : "+Fact(5));
            CountDown(5);
            Greet("mahmoud");
        }
    }
}
