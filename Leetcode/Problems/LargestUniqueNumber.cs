using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for april-leetcoding-challenge-2021
     */
    static class LargestUniqueNumber
    {
        public static int Solution(int[] A)
        {
            if (A.Length == 0) return -1;
            if (A.Length == 1) return A[0];

            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int i in A)
            {
                if (!map.ContainsKey(i))
                    map.Add(i, 0);

                map[i]++;
            }

            int result = -1;

            foreach (var p in map)
            {
                if (p.Value == 1 && p.Key > result)
                    result = p.Key;
            }

            return result;
        }
    }
}
