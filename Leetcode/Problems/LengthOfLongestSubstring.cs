using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for https://leetcode.com/problems/longest-substring-without-repeating-characters
     */
    class LengthOfLongestSubstring
    {
        public int Solution(string s)
        {
            int res = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0, j = 0; j < s.Length; j++)
            {
                if (map.ContainsKey(s[j]))
                {
                    i = Math.Max(map[s[j]], i);
                }
                map[s[j]] = j + 1;
                res = Math.Max(res, j - i + 1);
            }

            return res;
        }
    }
}
