using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class Program
    {
        // maximum of two integers
        public static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static int knapSack(int W, int[] wt,int[] val, int n)
        {
            int i, w;
            int[,] dp = new int[n + 1, W + 1];

            // Build table dp[][] in bottom up manner
            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        dp[i, w] = 0;

                    else if (wt[i - 1] <= w)
                        dp[i, w] = Math.Max(
                            val[i - 1]
                            + dp[i - 1, w - wt[i - 1]],
                            dp[i - 1, w]);
                    else
                        dp[i, w] = dp[i - 1, w];
                }
            }

            return dp[n, W];
        }
        static void Main(string[] args)
        {
            //Knapsack Problem : Returns the maximum value that
            // can be put in a knapsack of capacity W
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;

            Console.WriteLine(knapSack(W, wt, val, n));

            //Time Complexity: O(N*W) 
            //where ‘N’ is the number of weight element and ‘W’ is capacity.
        }
    }
}
