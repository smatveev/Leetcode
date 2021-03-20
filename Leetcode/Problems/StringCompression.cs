using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for https://leetcode.com/problems/string-compression
     */
    public static class StringCompression
    {
        public static int Compress(char[] chars)
        {
            if (chars.Length == 1) return 1;

            int count = 1;
            char cur = chars[0];
            int writepos = 0;

            for (int i = 1; i < chars.Length; i++)
            {
                if (i < chars.Length && cur == chars[i])
                {
                    count++;
                }
                else
                {
                    chars[writepos++] = cur;

                    if (count > 1)
                    {
                        foreach (var c in count.ToString())
                        {
                            chars[writepos++] = c;
                        }
                    }
                    count = 1;

                    if(i < chars.Length)
                        cur = chars[i];
                }
            }

            return writepos;
        }      
    }
}
