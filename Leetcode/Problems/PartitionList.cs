using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for https://leetcode.com/problems/partition-list
     */

    // Definition for singly-linked list.
    public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
             this.val = val;
             this.next = next;
         }
     }
     
    public static class PartitionList
    {
        public static ListNode Partition(ListNode head, int x)
        {
            if (head == null) return head;

            ListNode leftStart = new ListNode(-1),
                     leftCur = leftStart,
                     rightStart = new ListNode(-1),
                     rightCur = rightStart;

            while (head != null)
            {
                if (head.val < x)
                {
                    leftCur.next = head;
                    head = head.next;
                    leftCur = leftCur.next;
                    leftCur.next = null;
                }
                else
                {
                    rightCur.next = head;
                    head = head.next;
                    rightCur = rightCur.next;
                    rightCur.next = null;
                }
            }

            leftCur.next = rightStart.next;

            return leftStart.next;
        }
    }
}
