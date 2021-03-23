using Leetcode.Problems;
using System;

namespace Leetcode
{
    class Program
    {       

        static void Main(string[] args)
        {
            MedianFinder mf = new MedianFinder();
            mf.AddNum(1);
            mf.AddNum(2);
            mf.FindMedian();
            mf.AddNum(3);
            mf.FindMedian();


            Node head = new Node(7);
            head.next = new Node(13);
            head.next.random = head;
            Node sec = new Node(10);
            sec.random = head.next;

            var res = CopyRandomList.Solution(head);

            //ListNode AddTwo = AddTwoNumbers.Solution(new ListNode(5),
            //    new ListNode(5));

           // int a = StringCompression.Compress(new char[] { 'a', 'a', 'a', 'b', 'b', 'c', 'c', 'c' }); // { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });


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
