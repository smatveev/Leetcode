using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for https://leetcode.com/problems/reverse-words-in-a-string
     */
    class ReverseWords
    {
        public static string Solution(string s)
        {
            s = s.Trim();

            int i = 0;
            int j = s.Length - 1;
            int count = 0;

            while (i < j)
            {
                if (s[j] != ' ')
                {
                    count++;
                    j--;
                }

                if (s[j] == ' ')
                {
                    s = s.Insert(i, s.Substring(j + 1) + " ");
                    s = s.Remove(j + count + 1);
                    s = s.Trim();
                    i = i + count + 1;
                    count = 0;
                    j = s.Length - 1;
                }
            }

            s = s.Trim();

            return s;
        }

        public static string Solution2(string s) => 
            string.Join(" ", s.Split(' ').Where(_ => _ != "").Reverse());
    }
}
