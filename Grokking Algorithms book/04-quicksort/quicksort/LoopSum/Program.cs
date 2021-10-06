using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSum
{
    class Program
    {
        public static int Sum(List<int>List)
        {
            if (List.Count()<=0)
                return 0;
            else
            {
                int temp = List[0];
                List.RemoveAt(0);
                return temp+Sum(List);
            }

        }
        static void Main(string[] args)
        {
            List<int> Li = new List<int>();
            Li.Add(1);
            Li.Add(2);
            Li.Add(3);
            Li.Add(4);
            Li.Add(5);
            Console.WriteLine(Sum(Li));

        }
    }
}
