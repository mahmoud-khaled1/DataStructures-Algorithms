public class Solution {
    public int Reverse(int x) {
            long  ans = 0;
            long rem = 0;

            while(x!=0)
            {
                rem = (x % 10);
                ans = (ans * 10 + rem);
                x /= 10;
            }
            if (ans >= Math.Pow(-2, 31) && ans <= Math.Pow(2, 31) - 1)
                return (int)ans;
            else
                return 0;
        
    }
}