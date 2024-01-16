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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) {
            return null;
        }
        
        if (lists.Length == 1) {
            return lists[0];
        }
        
//         ListNode ln = new ListNode();
//         ListNode head = ln;
        
        ListNode list1 = lists[0];
        
        for (int i = 1; i < lists.Length; i++) {
                
            ListNode list2 = lists[i];

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

            list1 = head.next;
            
        }
        return list1;
    }
}