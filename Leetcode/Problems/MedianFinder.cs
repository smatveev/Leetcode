using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     *  solution for https://leetcode.com/problems/find-median-from-data-stream/
     */
    class MedianFinder
    {
        List<int> data;

        /** initialize your data structure here. */
        public MedianFinder()
        {
            data = new List<int>();
        }

        public void AddNum(int num)
        {
            data.Add(num);
        }

        public double FindMedian()
        {
            data.Sort();
            if (data.Count % 2 == 0)
            {
                int n1 = data[data.Count / 2];

                int index = data.Count / 2 - 1;
                int n2 = data[index];
                return (double)(n1 + n2) / 2;
            }
            else return data[data.Count / 2];
        }
    }
}
