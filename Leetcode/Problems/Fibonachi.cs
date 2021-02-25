using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    static class Fibonachi
    {
        public static int Exec(int N)
        {
            if (N <= 0)
                return 0;

            if (N == 1 || N == 2)
                return 1;

            return Exec(N - 1) + Exec(N - 2);
        }
    }
}
