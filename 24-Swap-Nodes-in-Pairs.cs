/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) return head;
            var temp = head.val;
            head.val = head.next.val;
            head.next.val = temp;
            head.next.next = SwapPairs(head.next.next);
            return head;
    }
}