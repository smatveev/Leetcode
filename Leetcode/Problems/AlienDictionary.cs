using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for https://leetcode.com/problems/verifying-an-alien-dictionary/
     */
    static class AlienDictionary
    {
        public static bool IsAlienSorted(string[] words, string order)
        {
            if (words.Count() < 2) return true;

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < order.Length; i++)
            {
                map.Add(order[i], i);
            }

            for (int i = 1; i < words.Length; i++)
            {

                int l = Math.Min(words[i].Length, words[i - 1].Length);

                for (int j = 0; j < l; j++)
                {                    
                    char left = words[i - 1][j];
                    char right = words[i][j];

                    if(left != right)
                    {
                        if (map[left] > map[right])
                            return false;
                        else
                            break;
                    }
                    if (j == l - 1 && words[i - 1].Length > words[i].Length)
                        return false;                    
                }
            }
            return true;
        }
    }
}
