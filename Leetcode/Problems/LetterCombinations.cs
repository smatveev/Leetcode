using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    /*
     * solution for https://leetcode.com/problems/letter-combinations-of-a-phone-number/
     */
    static class LetterCombinations
    {
        public static IList<string> Solution(string digits)
        {
            var res = new List<string>();

            if (string.IsNullOrEmpty(digits))
                return res;

            Dictionary<Char, char[]> map = new Dictionary<Char, char[]>();
            map.Add('2', new[] { 'a', 'b', 'c' });
            map.Add('3', new[] { 'd', 'e', 'f' });
            map.Add('4', new[] { 'g', 'h', 'i' });
            map.Add('5', new[] { 'j', 'k', 'l' });
            map.Add('6', new[] { 'm', 'n', 'o' });
            map.Add('7', new[] { 'p', 'q', 'r', 's' });
            map.Add('8', new[] { 't', 'u', 'v' });
            map.Add('9', new[] { 'w', 'x', 'y', 'z' });
            map.Add('0', null);

            res.Add("");

            foreach (char c in digits)
            {
                var next = new List<string>();
                var letters = map.Where(x => x.Key == c).First().Value;

                foreach (char letter in letters)
                {
                    foreach (string s in res)
                        next.Add(s + letter);
                }
                res = next;
            }
            return res;
        }
    }
}
