using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNubmers
{
    class Program
    {
        public static int CountNums(List<int>List,int indx=0)
        {
            if (indx==List.Count())
                return 0;
            else
            {
                
                return 1 + CountNums(List,++indx);
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
            Console.WriteLine(CountNums(Li));
            Console.WriteLine(Li.Count());
        }
    }
}
