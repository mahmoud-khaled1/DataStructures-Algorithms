using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_common_subsequence
{
    class Program
    {
        public static void LongestCommonSubsequence(string a,string b)
        {
            int[,] dp = new int[a.Length, b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    // The letters match
                    if (a[i] == b[j])
                    {
                        if (i > 0 && j > 0)
                        {
                            dp[i, j] = dp[i - 1, j - 1] + 1;
                        }
                        else
                        {
                            dp[i, j] = 1;
                        }
                    }
                    else
                    {
                        // The letters don't match.
                        if (i == 0 && j > 0)
                        {
                            dp[i,j] = dp[i,j - 1];
                        }
                        else if (i > 0 && j == 0)
                        {
                            dp[i,j] = dp[i - 1,j];
                        }
                        else if (i > 0 && j > 0)
                        {
                            dp[i,j] = Math.Max(dp[i - 1,j], dp[i,j - 1]);
                        }
                        else
                        {
                            dp[i,j] = 0;
                        }
                    }

                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    Console.Write(dp[i,j]+" ");
                }
                Console.WriteLine();
            }
            //      [0, 0, 0, 1]
            //      [0, 1, 1, 1]
            //      [0, 1, 2, 2]
            //      [0, 1, 2, 3]
            //So Ans =3

        }
        static void Main(string[] args)
        {
            //find the longest subsequence that two words have in common
            string a = "fish";
            string b = "fosh";
            LongestCommonSubsequence(a, b);

        }
    }
}
