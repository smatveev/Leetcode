using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algo
{
    public class BubbleSort
    {
        public void Sort(ref int[] a)
        {
            int j = 0;
            while (j < a.Length)
            {
                bool swapped = false;
                for (int i = 0; i < a.Length - j; i++)
                {
                    if (i + 1 < a.Length && a[i] > a[i + 1])
                    {
                        var temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) return;
                j++;
            }

        }
    }
}
