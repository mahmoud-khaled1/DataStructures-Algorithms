using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Problem
{
    class Program
    {
        public static int n;
        public static int[,] dp = new int[n+3,n+3];
        public static int[,] grid = new int[n + 3, n + 3];
        public static void InitDp()
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    dp[i, j] = -1;
                }
            }
        }
        public static void InitArray()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    grid[i, j] =int.Parse(Console.ReadLine());
                }
            }
        }
        public static bool Valid(int r,int c)
        {
            if (r < n && c < n)
                return true;
            else
                return false;
        }
        public static int MaxPath_Sum(int r,int c)
        {
            //1- Always handle invalid calls
            if (!Valid(r, c))
                return 0;

            //2-Handle Base Case
            if (r == n - 1 && c == n - 1)
                return grid[r, c];

            //Check if visited before
            if (dp[r, c] != -1)
                return dp[r, c];

            int path1 = MaxPath_Sum(r, c + 1); //right
            int path2 = MaxPath_Sum(r + 1, c); // down 

            return dp[r, c] = grid[r, c] + Math.Max(path1, path2);
            
        }
        static void Main(string[] args)
        {
            // Given grid of positive numbers, Start from 0,0
            // and end at n, n Move only to right and down -
            // find path with sum of numbers is maximum.
            //-----------------------------------------------

            // How to trun code to memization?
            // 1- Create array of input dimensions, and output of its return.
            // E.g. int mem[MAX][MAX];
            // Initialize it with a value that will never be a correct answer, e.g. -1
            // If value is -1, then it is not visited before. Else, use saved value
            //-------------------------------------------------

            n = 3;
            InitDp();
            InitArray();
            Console.WriteLine(MaxPath_Sum(0,0));

        }
    }
}
