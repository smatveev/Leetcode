using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for - https://leetcode.com/problems/group-anagrams
     */
    class GroupAnagrams
    {
        public IList<IList<string>> Solution(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                string s = String.Concat(strs[i].OrderBy(c => c));

                if (!map.ContainsKey(s))
                    map.Add(s, new List<string> { strs[i] });
                else
                {
                    map[s].Add(strs[i]);
                }
            }

            List<IList<string>> res = new List<IList<string>>(map.Values.ToList());

            return res;
        }
    }
}
