using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        public static void SelectionSort(int[]arr)
        {
            int min_idx;
            for (int i=0;i<arr.Length-1;i++)
            {
                min_idx = i;
                for (int k=i+1;k<arr.Length;k++)
                {
                    if(arr[k]<arr[min_idx])
                    {
                        min_idx = k;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

            //Print Array after Sorting it 
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 55, 66, 8, 71, 0, 11, 415 };

            SelectionSort(arr);

        }
    }
}
