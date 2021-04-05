using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    static class OnesAndZeroes
    {
        public static int Solution(string[] strs, int m, int n)
        {
            int[,] dp = new int[m+1,n+1];

            foreach(string s in strs)
            {
                int[] count = new int[2];
                for(int i = 0; i < s.Length; i++)
                    count[s[i] - '0']++;

                for (int z = m; z >= count[0]; z--)
                    for (int o = n; o >= count[1]; o--)
                        dp[z,o] = Math.Max(1 + dp[z - count[0], o - count[1]], dp[z,o]);
            }

            return dp[m,n];
        }
    }
}
