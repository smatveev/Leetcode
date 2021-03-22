using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for - https://leetcode.com/problems/add-two-numbers-ii/
     */
    class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();
            Stack<int> s3 = new Stack<int>();

            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            int carry = 0;

            while (s1.Count > 0 || s2.Count > 0)
            {
                int n1 = s1.Count > 0 ? s1.Pop() : 0;
                int n2 = s2.Count > 0 ? s2.Pop() : 0;

                int sum = (n1 + n2) + carry;
                carry = sum / 10;
                s3.Push(sum % 10);
            }

            if(carry > 0)
                s3.Push(carry);

            ListNode head = new ListNode(s3.Pop());
            ListNode res = head;

            while (s3.Count > 0)
            {
                head.next = new ListNode(s3.Pop());
                head = head.next;
            }
            return res;
        }
    }
}
