using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_common_substring
{
    class Program
    {
        public static void LongestCommonSubString(string a, string b)
        {
            int[,] dp = new int[a.Length, b.Length];
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (i == 0 || j == 0)
                        dp[i, j] = 0;
                    else if (a[i - 1] == a[j - 1])
                    {
                        dp[i, j]
                            = dp[i - 1, j - 1] + 1;

                        result
                            = Math.Max(result, dp[i, j]);
                    }
                    else
                        dp[i, j] = 0;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    Console.Write(dp[i, j] + " ");
                }
                Console.WriteLine();
            }
            //      [0, 0, 0, 0]
            //      [0, 1, 0, 0]
            //      [0, 0, 2, 0]
            //      [0, 0, 0, 3]
            //So Ans =3


        }
        static void Main(string[] args)
        {
            //find the longest substring that two words have in common
            string a = "fish";
            string b = "hish";
            LongestCommonSubString(a, b);
        }
    }
}
