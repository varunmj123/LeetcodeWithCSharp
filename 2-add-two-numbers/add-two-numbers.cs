public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        ListNode counter1 = l1;
        ListNode counter2 = l2;
        int carryForward = 0;

        while (counter1 != null || counter2 != null || carryForward != 0) {
            int sum =
                (counter1 != null ? counter1.val : 0) +
                (counter2 != null ? counter2.val : 0) +
                carryForward;

            carryForward = sum / 10;
            ListNode newNode = new ListNode(sum % 10);

            tail.next = newNode;
            tail = newNode;

            if (counter1 != null) counter1 = counter1.next;
            if (counter2 != null) counter2 = counter2.next;
        }

        return dummy.next;
    }
}
