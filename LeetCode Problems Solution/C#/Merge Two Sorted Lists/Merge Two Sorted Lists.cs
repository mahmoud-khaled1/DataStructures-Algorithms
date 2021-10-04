// Source : https://leetcode.com/problems/merge-two-sorted-lists/
// Author : mahmoud khaled
// Date   : 2021-7-28

/********************************************************************************** 
* 
Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.

*               
**********************************************************************************/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
         
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        
         var newHead = new ListNode(0); 
         var temp = newHead; 
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                temp.next=l1;
                l1=l1.next;
            }
            else
            {
                
                temp.next=l2;
                l2=l2.next;
            }
            temp = temp.next;
        }
        
        
        if (l1 != null) temp.next = l1;
        if (l2 != null) temp.next = l2;
        return newHead.next;
        
    }
}