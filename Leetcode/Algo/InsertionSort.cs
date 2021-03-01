using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algo
{
    class InsertionSort
    {
        static void insertionSort2(int n, int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }

                foreach (var num in arr)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }

        }
    }
}
