using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElement
{
    class Program
    {
        public static int MaxElement(List<int>List,int indx=0,int mx=int.MinValue)
        {
            if(indx==List.Count())
            {
                return mx;
            }
            else
            {
                if (List[indx] > mx)
                    mx = List[indx];
                return MaxElement(List, ++indx, mx);
            }
        }
        static void Main(string[] args)
        {
            List<int> Li = new List<int>();
            Li.Add(1);
            Li.Add(2);
            Li.Add(113);
            Li.Add(4);
            Li.Add(5);
            Console.WriteLine(MaxElement(Li));
            Console.WriteLine(Li.Count());
        }
    }
}
