// Source : https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
// Author : mahmoud khaled
// Date   : 2021-8	-3

/********************************************************************************** 
* 
A string s is called good if there are no two different characters in s that have the same frequency.

Given a string s, return the minimum number of characters you need to delete to make s good.

The frequency of a character in a string is the number of times it appears in the string. For example, in the string "aab", the frequency of 'a' is 2, while the frequency of 'b' is 1.

 

*               
**********************************************************************************/
public class Solution {
    public int MinDeletions(string s) {
        if (string.IsNullOrEmpty(s))
                return 0;

            int ans = 0, curfre = int.MaxValue;

            Dictionary<char, int> Dic = new Dictionary<char, int>();

             foreach (var c in s)
        {
            if (!Dic.ContainsKey(c))
                Dic.Add(c, 0);
            
            Dic[c] += 1;
        }

            foreach (var item in Dic.OrderByDescending(x=>x.Value).Select(x=>x.Value).ToList())
            {
                if(curfre<=item)
                {
                    ans += curfre == 0 ? item : item - curfre + 1;
                    curfre = curfre == 0 ? 0 : curfre - 1;
                }
                else
                {
                    curfre = item;
                }
            }
            return ans;

        
    }
}