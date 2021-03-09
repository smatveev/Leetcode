using System.Collections.Generic;

namespace Leetcode.Algo
{
    class MergeSort
    {
        public int[] array = new int[] { 2, 54, 76, 3, 76, 3, 76, 2, 2, 7, 9, 7, -34, -34, -3, 545454, 0 };

        public List<int> MergeSortAlg(List<int> arr)
        {
            if (arr.Count < 2)
                return arr;

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int mid = arr.Count / 2;

            for (int i = 0; i < mid; i++)
                left.Add(arr[i]);

            for (int i = mid; i < arr.Count; i++)
                right.Add(arr[i]);

            left = MergeSortAlg(left);
            right = MergeSortAlg(right);

            return Merge(left, right);
        }

        public List<int> Merge(List<int> a, List<int> b)
        {
            int i = 0, j = 0;
            List<int> res = new List<int>();

            while (i < a.Count && j < b.Count)
            {
                if (a[i] < b[j])
                {
                    res.Add(a[i]);
                    i++;
                }
                else
                {
                    res.Add(b[j]);
                    j++;
                }
            }

            for (; i < a.Count; i++)
                res.Add(a[i]);

            for (; j < b.Count; j++)
                res.Add(b[j]);

            return res;
        }
    }
}
