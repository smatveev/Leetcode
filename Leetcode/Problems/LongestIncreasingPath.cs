using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     solutiobn for - https://leetcode.com/problems/longest-increasing-path-in-a-matrix/solution/
     */
    public class LongestIncreasingPath
    {

        private int[][] dirs =
        {
        new int[] {0, 1},
        new int[] {1, 0},
        new int[] {0, -1},
        new int[] {-1, 0}
    };
        private int rows, cols;

        public int Solution(int[][] matrix)
        {
            if (matrix.Length == 0) return 0;

            int res = 0;
            rows = matrix.Length;
            cols = matrix[0].Length;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    res = Math.Max(res, dfs(matrix, row, col));
                }
            }
            return res;
        }

        public int dfs(int[][] m, int row, int col)
        {
            int res = 1;
            foreach (int[] dir in dirs)
            {
                int x = row + dir[0];
                int y = col + dir[1];
                if (x >= 0 && x < rows && y >= 0 && y < cols && m[x][y] > m[row][col])
                    res = Math.Max(res, dfs(m, x, y));
            }
            return res++;
        }
    }
}
