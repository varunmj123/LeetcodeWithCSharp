public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        // prev is head of reversed list
        if (n == 1) {
            prev = prev.next;
        } else {
            int counter = 1;
            ListNode pointer = prev;

            while (counter < n - 1 && pointer != null) {
                pointer = pointer.next;   // FIX: move pointer correctly
                counter++;
            }

            if (pointer != null && pointer.next != null) {
                pointer.next = pointer.next.next; // remove nth
            }
        }

        curr = prev;
        prev = null;

        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        return prev;
    }
}
