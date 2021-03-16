using System;

namespace Leetcode.Problems
{
    /*
     solution for the problem https://leetcode.com/problems/rectangle-overlap
     */
    class IsRectangleOverlap
    {
        public static bool Solution(int[] rec1, int[] rec2)
        {
            return (Math.Min(rec1[2], rec2[2]) > Math.Max(rec1[0], rec2[0]) &&
                    Math.Min(rec1[3], rec2[3]) > Math.Max(rec1[1], rec2[1]));
        }
    }
}
