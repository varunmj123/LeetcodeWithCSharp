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
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;

        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
            if(slow == fast){
                return true;
            }
        }
        return false;
    }
}


// public class Solution {
//     public bool HasCycle(ListNode head) {
//         if(head == null){
//             return false;
//         }
//         var seenNodes  = new Dictionary<ListNode, int>();
//         while(head != null){
//             if(seenNodes.ContainsKey(head)){
//                 return true;
//             }  
//             seenNodes[head] = 1;
//             head = head.next;
//         }
//         return false;
//     }
// }
