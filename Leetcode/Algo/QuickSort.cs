using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algo
{
    class QuickSort
    {
        static void quickSort(int[] ar, int from, int to)
        {
            int sep = Partition(ar, from, to);
            quickSort(ar, from, sep);
            quickSort(ar, sep + 1, to);
        }

        private static int Partition(int[] ar, int from, int to)
        {
            int left = from;
            int right = to;
            int pivot = ar[from];

            while (left < right)
            {
                while (ar[left] < pivot)
                {
                    left++;
                }

                while (ar[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    var tmp = ar[left];
                    ar[left] = ar[right];
                    ar[right] = tmp;

                    left++;
                    right--;
                }
                else
                {
                    foreach (int num in ar)
                    {
                        Console.Write("{0} ", num);
                    }
                    Console.WriteLine();
                    return left;
                }
            }
            return left;
        }

        /*
         * 
         *             int[] ar = { 5, 8, 1, 3, 7, 9, 2 };
                    quickSort(ar, 0, 6);
         */
    }
}
