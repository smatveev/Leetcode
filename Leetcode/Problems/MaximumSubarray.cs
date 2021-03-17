using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for problem - https://leetcode.com/problems/maximum-subarray/
     */
    class MaximumSubarray
    {
        public static int Solution(int[] nums)
        {
            int curSum = nums[0];
            int maxSum = curSum;

            for (int i = 1; i < nums.Length; i++)
            {
                curSum = Math.Max(nums[i], curSum + nums[i]);
                maxSum = Math.Max(curSum, maxSum);
            }

            return maxSum;
        }
    }
}
