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
    public ListNode RotateRight(ListNode head, int k) {
        
        
        
        if (head == null) {
            return null;
        }
        
        if (head.next == null) {
            return head;
        }
        
        int count = 0;
        ListNode c = head;
        while(c != null) {
            count++;
            c = c.next;
        }
        
        k = k % count;
        
        for (int i = 0; i < k; i++) {
            
            ListNode temp = head;
            ListNode prev = null;
            while (temp.next != null) {
                prev = temp;
                temp = temp.next;
            }
            
            temp.next = head;
            head = temp;
            prev.next = null;
        }
        
        return head;
    }
}