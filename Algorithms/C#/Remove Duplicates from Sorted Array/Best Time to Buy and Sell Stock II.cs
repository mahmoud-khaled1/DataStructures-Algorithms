// Source : https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
// Author : mahmoud khaled
// Date   : 2021-7-29

/********************************************************************************** 
* 
You are given an array prices where prices[i] is the price of a given stock on the ith day.

Find the maximum profit you can achieve. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).

Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).
*               
**********************************************************************************/
public class Solution {
    public int MaxProfit(int[] prices) {
        int max_profile=0;
        int min_price=999999;
        int sum=0;
        for(int i=0;i<prices.Length-1;i++)
        {
            if(prices[i]<prices[i+1])
            {
                sum+=prices[i+1]-prices[i];
            }
        }
        return sum;
        
        
    }
}