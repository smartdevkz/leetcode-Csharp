using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy344
{
    class Solution
    {
        public void ReverseString(char[] s)
        {
            int i = 0;
            while (s.Length - 2 * i - 1 > 0)
            {
                var t = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = t;
                i++;
            }
            return;
        }
    }
}
