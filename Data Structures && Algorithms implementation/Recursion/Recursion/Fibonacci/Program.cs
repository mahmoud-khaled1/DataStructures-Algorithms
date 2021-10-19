using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static int Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(8)); // O(2^n) 
            //So if we want to Optimized the Solution we use DP . 
        }
    }
}
