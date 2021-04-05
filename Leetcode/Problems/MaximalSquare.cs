using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * soluiton for https://leetcode.com/problems/maximal-square
     */
    static class MaximalSquare
    {
        static public int Solution(char[][] matrix)
        {
            int res = 0;

            int rows = matrix.Length;
            if (rows == 0) return 0;

            int cols = matrix[0].Length;
            int[,] dp = new int[rows + 1, cols + 1];

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (matrix[i - 1][j - 1] == '1')
                    {
                        dp[i, j] = Math.Min((dp[i, j - 1]), Math.Min((dp[i - 1, j]), (dp[i - 1, j - 1]))) + 1;
                        res = Math.Max(res, dp[i, j]);
                    }
                }
            }

            return res * res;
        }
    }
