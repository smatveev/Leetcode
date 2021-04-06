using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * https://leetcode.com/problems/minimum-operations-to-make-array-equal/
     */
    static class MinimumOperationsToMakeArrayEqual
    {
        static public int Foo(int n)
        {
            int res = 0;
            while (n > 0)
            {
                res += n - 1;
                n = n - 2;
            }
            return res;
        }
    }
}
