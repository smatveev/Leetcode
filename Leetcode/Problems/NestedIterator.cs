using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * one stack solution for https://leetcode.com/problems/flatten-nested-list-iterator/
     */
    public class NestedIterator
    {
        private Stack<NestedInteger> s;
        private List<NestedInteger> v;

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            s = new Stack<NestedInteger>();
            v = new List<NestedInteger>();

            for (int i = nestedList.Count - 1; i >= 0; i--)
            {
                v.Add(nestedList[i]);
                s.Push(nestedList[i]);
            }
        }

        private void TakeStack()
        {
            while (s.Count > 0 && !s.Peek().IsInteger())
            {
                var el = s.Pop();
                for (int i = el.GetList().Count - 1; i >= 0; i--)
                {
                    v.Add(el.GetList()[i]);
                    s.Push(el.GetList()[i]);
                }
            }
        }

        public bool HasNext()
        {
            TakeStack();
            return s.Count > 0;
        }

        public int Next()
        {
            TakeStack();
            return s.Pop().GetInteger();
        }
    }

    // This is the interface that allows for creating nested lists.
    // You should not implement it, or speculate about its implementation
    public interface NestedInteger {
        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }
}