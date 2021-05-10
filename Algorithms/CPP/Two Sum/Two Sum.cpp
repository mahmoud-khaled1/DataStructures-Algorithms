// Source : https://leetcode.com/problems/two-sum/
// Author : mahmoud khaled
// Date   : 2021-05-10

/********************************************************************************** 
* 
*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
*               
**********************************************************************************/

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        vector <int>  a;
        for(int i=0;i<nums.size()-1;i++)
        {
            for(int j=i+1;j<nums.size();j++)
            {
                
                if((nums[i]+nums[j])==target)
                {
                    
                    a.push_back(i);
                    a.push_back(j);
                }
                
            }
            
        }
        return a ;
    }
};