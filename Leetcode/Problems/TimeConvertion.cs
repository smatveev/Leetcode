using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    class TimeConvertion
    {
        //test
        // timeConversion("12:45:54PM");

        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            string hours;

            char[] arr = s.ToCharArray();

            if (arr[arr.Length - 2] == 'P')
            {
                hours = (12 + int.Parse(s.Substring(0, 2))).ToString();
                if (hours == 24.ToString())
                {
                    hours = "12";
                }
            }

            else
            {
                int h = int.Parse(s.Substring(0, 2));
                if (h < 10)
                    hours = string.Concat("0", h.ToString());
                else if (h == 12)
                    hours = "00";
                else
                    hours = h.ToString();
            }

            return string.Concat(hours, s.Substring(2, 6));
        }

    }
}
