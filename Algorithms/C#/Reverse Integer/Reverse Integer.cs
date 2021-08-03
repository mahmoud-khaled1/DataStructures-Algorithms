// Source : https://leetcode.com/problems/reverse-integer/
// Author : mahmoud khaled
// Date   : 2021-8-3

/********************************************************************************** 
* 

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit 
integer range [-231, 231 - 1], then return 0.
*               
**********************************************************************************/
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