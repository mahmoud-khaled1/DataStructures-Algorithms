using System;
namespace BinarySearch
{
    class Program
    {
        private static int BinarySearch(int []arr,int item)
        {
            var low = 0;
            var high = arr.Length-1;
            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = arr[mid];
                if (guess == item) return mid;
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int []arr= { 0,1,3,5,9,77,88,99,100,150};
            // We will return index of number 77 or -1 if doesn't exist .
            Console.WriteLine(BinarySearch(arr,77));
        }
    }
}
