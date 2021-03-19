using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {

            var BFS = new BFS();
            BFS.Execute();
            Console.ReadLine();

            Console.WriteLine(Fibonachi.Exec(6));



            Console.WriteLine("LL");
            ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
            Leetcode.ListNode list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            //while(list != null)
            //{
            //    Console.WriteLine("curr node = {0}", list.val);
            //    list = list.next;
            //}

            Console.WriteLine("Rev LL");
            var revlist = reverseLinkedList.ReverseList(list);
            while (revlist != null)
            {
                Console.WriteLine("curr node = {0}", revlist.val);
                revlist = revlist.next;
            }

            Console.ReadLine();
        }
    }
}
