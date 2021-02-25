using System;

namespace Leetcode
{
    static class Palindrome
    {
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;

            ListNode next = head;
            ListNode nextx2 = head;

            //calc the middle of list
            while (nextx2.next != null && nextx2.next.next != null)
            {
                next = next.next;
                nextx2 = nextx2.next.next;
            }

            // reverse
            ListNode cur = next.next;
            ListNode prev = null;
            while (cur != null)
            {
                var tmp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = tmp;
            }

            //checking by pairs
            while (prev != null)
            {
                if (head.val != prev.val) return false;
                prev = prev.next;
                head = head.next;
            }
            return true;
        }
    }
}