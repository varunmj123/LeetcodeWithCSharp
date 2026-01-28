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
    //[2 - > 4 ->6 ->8]
    //[2 - > 4 <-6 <-8]
    // slow at 4
    public void ReorderList(ListNode head) {
        ListNode fast = head.next;
        ListNode slow = head;

        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        // Now fast head is at the end while slow head is in the middle
        // We need to reverse the list from slow to null;
        ListNode curr = slow.next;
        slow.next = null;
        ListNode prev = null;
        while(curr != null){
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        } 
        // Now current is at the end of the list at null?
        // prev is at 8 
        ListNode first = head;
        curr = prev;
        while(curr != null){
            ListNode temp = first.next;
            ListNode temp2 = curr.next;
            first.next = curr;
            curr.next = temp;
            first = temp;
            curr = temp2;
        } // List becomes  [2 -> 8 ->4 -> 6]      
    }
}
