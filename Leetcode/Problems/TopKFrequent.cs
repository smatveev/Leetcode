using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for https://leetcode.com/problems/top-k-frequent-elements/
     */
    static class TopKFrequent
    {
        public static int[] Solution(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int n in nums)
            {
                if (!map.ContainsKey(n))
                    map.Add(n, 0);

                map[n]++;
            }

            return map.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToList<int>().ToArray();
        }
    }
}
