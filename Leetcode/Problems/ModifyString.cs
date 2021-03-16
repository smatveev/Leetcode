namespace Leetcode.Problems
{
    /*
     * The problem description - https://leetcode.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/
     */
    class ModifyString
    {
        public static string Solution(string s)
        {
            char[] abc = new char[] { 'a', 'b', 'c' };
            char prev;
            char next;

            for (int i = 0; i < s.Length; i++)
            {
                prev = (i > 0) ? s[i - 1] : '-';
                next = i < s.Length - 1 ? s[i + 1] : '-';

                if (s[i] == '?')
                {
                    int j = 0;
                    while (true)
                    {
                        if (prev != abc[j] && next != abc[j])
                        {
                            s = s.Remove(i, 1).Insert(i, abc[j].ToString());
                            break;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
            }

            return s;
        }
    }
}
