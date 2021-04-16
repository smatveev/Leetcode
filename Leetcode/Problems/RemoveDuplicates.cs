using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/
     */
    static class RemoveDuplicates
    {
        public static string Solution(string s, int k)
        {

            if (s.Length < k) return s;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + k <= s.Length)
                {
                    bool isDup = true;
                    for(int j = i; j < i+k-1; j++)
                    {
                        if (s[j] != s[j + 1])
                        {
                            isDup = false;
                            break;
                        }
                    }
                    if(isDup)
                    {
                        s = s.Remove(i, k);
                        i = -1;
                    }
                }
            }
            return s;
        }
    }
}
