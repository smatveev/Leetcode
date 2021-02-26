using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Structures
{
    class QueueUsingStacks
    {
        Stack<int> s1;
        Stack<int> s2;
        /** Initialize your data structure here. */
        public QueueUsingStacks()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (s1.Count == 0)
                s1.Push(x);
            else
            {
                while (s1.Count > 0) 
                    s2.Push(s1.Pop());

                s1.Push(x);
                while (s2.Count > 0)
                    s1.Push(s2.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return s1.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return s1.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return s1.Count == 0;
        }
    }
}
