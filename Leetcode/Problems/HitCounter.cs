using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{

    /*
     * solution for https://leetcode.com/problems/design-hit-counter
     */
    public class HitCounter
    {
        Dictionary<int, int> data;

        /** Initialize your data structure here. */
        public HitCounter()
        {
            data = new Dictionary<int, int>();
        }

        /** Record a hit.
            @param timestamp - The current timestamp (in seconds granularity). */
        public void Hit(int timestamp)
        {
            if (data.ContainsKey(timestamp))
            {
                data[timestamp]++;
            }
            else
            {
                data.Add(timestamp, 1);
            }
        }

        /** Return the number of hits in the past 5 minutes.
            @param timestamp - The current timestamp (in seconds granularity). */
        public int GetHits(int timestamp)
        {
            foreach (var a in data)
            {
                Console.WriteLine(a);
            }

            int res = 0;
            foreach (int key in data.Keys)
            {
                if (timestamp - key < 300)
                    res += data[key];
            }

            return res;
        }
    }
}
