using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Structures
{
    class OneWayLinkedList
    {
        /*tests
         
                     LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            list.InsertInTail(4);
            list.InsertInTail(5);

            list.InsertInPos(3, 99);

            list.tail.next = list.head.next.next;
            //list.DeleteInPos(5);

            list.IsCircle();
          
         */

        public Node head;
        public Node tail;

        public OneWayLinkedList()
        {
            head = null;
            tail = null;
        }

        public bool IsCircle()
        {
            Node cur = head;
            Node cur2x = head;

            while (cur.next != null)
            {
                cur = cur.next;
                cur2x = cur2x.next.next;
                if (cur == cur2x)
                    return true;
            }
            return false;
        }

        public void Insert(int value)
        {
            Node node = new Node(value);

            if (head == null)
            {
                head = node;
                tail = node;
                return;
            }

            Node cur = head;

            while (cur.next != null)
                cur = cur.next;

            cur.next = node;
            tail = cur.next;

            return;
        }

        public void InsertInTail(int value)
        {
            Node node = new Node(value);

            if (tail == null)
            {
                head = node;
                tail = node;
                return;
            }

            tail.next = node;
            tail = tail.next;
        }

        public void InsertInPos(int pos, int value)
        {
            Node cur = head;
            while (pos - 1 > 0)
            {
                if (cur.next != null)
                {
                    cur = cur.next;
                    pos--;
                }
                else
                    throw new Exception("dsf");
            }
            Node newNode = new Node(value);
            newNode.next = cur.next;
            cur.next = newNode;

            return;
        }

        public void Delete()
        {
            head = null;
            tail = null;
        }

        public void DeleteInPos(int pos)
        {
            Node cur = head;
            while (pos - 1 > 0)
            {
                if (cur.next != null)
                {
                    cur = cur.next;
                    pos--;
                }
                else
                    throw new Exception("dsf");
            }

            if (tail == cur.next)
                tail = cur;

            cur.next = cur.next.next;

            return;
        }
    }
    public class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
        }
    }
}
