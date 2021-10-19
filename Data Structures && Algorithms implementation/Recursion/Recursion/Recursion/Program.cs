using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        public static string reverseString(string str)
        {
            //base case 
            if(str=="")
            {
                return "";
            }
            return reverseString(str.Substring(1)) + str[0];

        }
        public static bool Check_Palindrom(string s,int start,int end)
        {
            if(start==end||end-start==1)
            {
                return true; 
            }
            else
            {
                if(s[start]==s[end])
                {
                    return Check_Palindrom(s, start + 1, end - 1);
                }
                else
                {
                    return false;
                }
            }
        }
        public static string  findBinary(int decimalNum,string result)
        {
            if(decimalNum==0)
            {
                return result;
            }
            else
            {
                result = (decimalNum % 2).ToString() + result;
                return findBinary(decimalNum / 2, result);
            }
        }
        public static int Summation(int num)
        {
            if (num <= 1)
                return 1;
            return num + Summation(num - 1);

        }
        static void Main(string[] args)
        {
            // P1) Reverse string using Recursion 
            string ans = reverseString("mahmoud");
            Console.WriteLine(ans);
            //-----------------------------------
            // P2) Check if string is palindrom or not 
            string str = "madam";
            Console.WriteLine(Check_Palindrom(str, 0,str.Length-1));
            //-----------------------------------
            // P3)Convert number from decimal to binary
            Console.WriteLine(findBinary(50,""));
            //-----------------------------------
            // P4) Summation from 1 to n
            Console.WriteLine(Summation(10));
        }
    }
}
