using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_basics
{
    class Program
    {
        public static int[] arr = new int[100];
        public static void IniArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
        }
        public static int fibSave(int num)
        {
            if (num <= 1)
                return 1;
            if (arr[num] != -1)
                return arr[num];
            return arr[num] = fibSave(num - 2) + fibSave(num - 1);
        }

        public static int Fib(int n)
        {
            if (n <= 1)
                return 1;
            else
                return Fib(n - 2) + Fib(n - 1);
        }
        private static int  bottomUp_Dp_Fib_(int n)
        {
            int[] fib = new int[105];
            fib[0] = 1;     // base case
            fib[1] = 1;    // base case

            for (int i = 2; i <= 100; ++i)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
              
            }// bottom up according to recurrence

            return fib[n];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(5)); // O(2^n)

            // Top-Down approch (Memoization)
            IniArray();
            Console.WriteLine(fibSave(5)); // O(n)

            // bottom up (Dp)
            Console.WriteLine(bottomUp_Dp_Fib_(5));

        }

        
    }
}
