using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    class Program
    {
        public static IEnumerable<int> QuickSort(IEnumerable<int> List)
        {
            if (List.Count() < 2)
                return List;
            else
            {
                var Pivot = List.First(); 
                var Less = List.Skip(1).Where(a => a <= Pivot);
                var greater = List.Skip(1).Where(a => a > Pivot);
                return QuickSort(Less).Union(new List<int> { Pivot })
                    .Union(QuickSort(greater));
            }

        }

        public static void Main(string[] args)
        {
            var arr = new List<int> { 87, 50, 20, 3, 99, 1 };
            Console.WriteLine(string.Join(" ", QuickSort(arr)));

        }
    }
}
