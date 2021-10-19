using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        public static int Binary_Search(int[]arr,int left,int right,int item)
        {
            if(left>right)
                return -1;
            
            int mid = (left + right) / 2;
            if (arr[mid] == item)
                return 1;
            if (arr[mid] > item)
               return Binary_Search(arr, left, mid + 1,item);
            
            return Binary_Search(arr, mid + 1, right, item);

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 6, 88, 99, 100 };
            if(Binary_Search(arr, 0, arr.Length - 1, 99)==-1)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine("Found");
        }
    }
}
