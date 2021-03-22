using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for - https://leetcode.com/problems/copy-list-with-random-pointer/
     */
    class CopyRandomList
    {
        public static Node Solution(Node head)
        {
            if (head == null) return head;

            Node curHead = head;

            Dictionary<int, Node> map = new Dictionary<int, Node>();

            Node resHead = new Node(curHead.val);
            map.Add(head.GetHashCode(), resHead);

            Node result = resHead;

            head = head.next;

            while (head != null)
            {
                Node copyNode = new Node(head.val);
                map.Add(head.GetHashCode(), copyNode);

                head = head.next;
                resHead.next = copyNode;
                resHead = resHead.next;
            }

            while (curHead != null)
            {
                Node copy = map[curHead.GetHashCode()];

                Node copyRandom = null;

                if (curHead.random != null)
                    copyRandom = map[curHead.random.GetHashCode()];

                copy.random = copyRandom;

                curHead = curHead.next;
            }

            return result;
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
