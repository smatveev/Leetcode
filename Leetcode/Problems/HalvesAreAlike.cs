using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * https://leetcode.com/problems/determine-if-string-halves-are-alike
     */
    static class HalvesAreAlike
    {
        public static bool Solution(string s)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int cl = 0;
            int cr = 0;

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (vowels.Contains(Char.ToLower(s[i])))
                    cl++;

                if (vowels.Contains(Char.ToLower(s[j])))
                    cr++;
            }

            return cl == cr;
        }
    }
}
