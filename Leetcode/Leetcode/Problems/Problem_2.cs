using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_2 : IProblem
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers(l1, l2, 0);
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carryOver)
        {
            int l1Value = l1?.val ?? 0;
            int l2Value = l2?.val ?? 0;

            int sum = l1Value + l2Value + carryOver;

            if (sum == 0 && l1 == null && l2 == null)
            {
                return null;
            }
            else
            {
                ListNode currentNode = new ListNode(sum % 10);
                currentNode.next = AddTwoNumbers(l1?.next, l2?.next, sum / 10);
                return currentNode;
            }
        }

        public void ExecuteSolution()
        {
            var l1 = new ListNode(9);
            l1.next = new ListNode(9);
            l1.next.next = new ListNode(9);

            var l2 = new ListNode(1);
            l2.next = new ListNode(1);
            l2.next.next = new ListNode(1);

            var res = AddTwoNumbers(l1, l2);

            Console.WriteLine("Output: " + res.val + res.next.val + res.next.next.val + res.next.next.next?.val);
        }
    }
}
