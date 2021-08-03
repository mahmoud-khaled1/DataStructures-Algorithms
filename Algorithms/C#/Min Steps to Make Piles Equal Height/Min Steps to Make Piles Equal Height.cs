// Source : 
// Author : mahmoud khaled
// Date   : 2021-8	-3

/********************************************************************************** 
* 

Alexa is given n piles of equal or unequal heights. In one step, Alexa can remove any number of boxes from the pile which has the maximum height and try to make it equal to the one which is just lower than the maximum height of the stack. Determine the minimum number of steps required to make all of the piles equal in height.

Example 1:

Input: piles = [5, 2, 1]
Output: 3
Explanation:
Step 1: reducing 5 -> 2 [2, 2, 1]
Step 2: reducing 2 -> 1 [2, 1, 1]
Step 3: reducing 2 -> 1 [1, 1, 1]
So final number of steps required is 3.
 

*               
**********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        public static int MinNumOfStep(int[] arr)
        {
            int steps = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                    steps += i + 1;
            }
            return steps;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 };


            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine(MinNumOfStep(arr));

            Console.ReadLine();

        }
    }
}
