using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;

            ListNode prev = null;
            ListNode curr = head;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.next; //keep
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }
}
