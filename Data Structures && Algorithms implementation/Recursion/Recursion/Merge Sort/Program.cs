using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {
        public static void mergeSort(int[]arr,int start,int end)
        {
            //base case 
            if (start >= end)
                return;

            //Divide
            int mid = (start + end) / 2;
            mergeSort(arr, start, mid);
            mergeSort(arr, mid + 1, end);

            //Conquer
            Sort(arr, start, end);
        }
        public static void Sort(int []arr,int s,int e)
        {
            int mid = (s + e) / 2;

            int i = s;
            int j = mid + 1;
            int k = s;
            int []temp=new int[1000];

            while (i <= mid && j <= e)
            {
                if (arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= e)
            {
                temp[k++] = arr[j++];
            }
            for (int ii = s; ii <= e; ii++)
            {
                arr[ii] = temp[ii];
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 3, 2, 0, -1, 7, 10, 9, 20 };
            mergeSort(arr, 0, arr.Length-1); //O(n log(n) )

            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
