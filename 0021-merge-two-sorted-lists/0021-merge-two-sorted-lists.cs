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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        if (list1 == null && list2 == null) {
            return null;
        } 
        
        if (list1 == null) {
            return list2;
        }
        
        if (list2 == null) {
            return list1;
        }
        
        ListNode res = new ListNode();
        ListNode head = res;
        while (list1 != null && list2 != null) {
            ListNode temp = new ListNode();
            if (list1.val <= list2.val) {
                temp.val = list1.val;
                list1 = list1.next;
            } else {
                temp.val = list2.val;
                list2 = list2.next;
            }
            res.next = temp;
            res = res.next;
        }
        
        if (list1==null) {
            res.next = list2;
        }
        
        if (list2 == null) {
            res.next = list1;

        }
        
        return head.next;
    }
}