// Source : 
// Author : mahmoud khaled
// Date   : 2021-8-3

/********************************************************************************** 
* 

Given a string, what is the minimum number of adjacent swaps required to convert a string into a palindrome. If not possible, return -1.

Example 1:

Input: "mamad"
Output: 3
Example 2:

Input: "asflkj"
Output: -1
 

*               
**********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        public static bool isShuffledPalindrome(string str)
        {
            if (str.Length <= 1)
                return false;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item] += 1;
                }
            }
            int NumEven = dict.Values.Count(x => x % 2 == 0);
            int NumOdd = dict.Values.Count(x => x % 2 != 0);

            if (NumEven > 0 && NumOdd <= 1)
                return true;
            else
                return false;
        }
        public static void swap(char[] chars, int k, int i)
        {
            char temp = chars[k];
            chars[k] = chars[i];
            chars[i] = temp;
        }
        public static int minimum_number_OfSwapping(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;
            if (!isShuffledPalindrome(s))
                return -1;

            char[] chars = s.ToCharArray();
            int leftPointer = 0;
            int rightPointer = chars.Length - 1;
            int totalSwaps = 0;

            while (rightPointer > leftPointer)
            {
                //Check if left and right char is matching .
                if (chars[leftPointer] == chars[rightPointer])
                {
                    leftPointer++;
                    rightPointer--;
                }
                //If Not Matching !
                else
                {
                    int k = rightPointer;
                    while (k > leftPointer && chars[k] != chars[leftPointer]) k--;
                    if (k == leftPointer) // No matching character found
                    {
                        swap(chars, k, k + 1);
                        totalSwaps++;
                        k++;
                    }
                    //When Matching character found swap until K reaches p2 position
                    else
                    {
                        while (k < rightPointer)
                        {
                            swap(chars, k, k + 1);
                            totalSwaps++;
                            k++;
                        }
                        leftPointer++; rightPointer--;
                    }
                }

            }
            return totalSwaps;
        }

        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Console.WriteLine(minimum_number_OfSwapping(input));
        }
    }
}
