using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Program
    {
        public static void swap(ref int x, ref int  y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void heapify(int []arr, int n, int i)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int max = i;
            if (l < n && arr[l] > arr[max])
                max = l;
            if (r < n && arr[r] > arr[max])
                max = r;

            if (max != i)
            {
                swap(ref arr[i],ref arr[max]);
                heapify(arr, n, max);
            }
        }
        public static void buildHeap(int []arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
        }
        public static void heapSort(int []arr, int n)
        {

            buildHeap(arr, n);
            for (int i = n - 1; i >= 0; i--)
            {
                swap( ref arr[0],ref arr[i]);
                heapify(arr, i, 0);
            }

        }
        public static void print(int []arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int []arr = { 90, 10, 40, 70, 5 };
            int n =arr.Length;

            heapSort(arr, n);
            print(arr, n);
        }
    }
}
