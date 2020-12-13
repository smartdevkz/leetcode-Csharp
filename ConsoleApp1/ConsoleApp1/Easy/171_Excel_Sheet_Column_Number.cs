using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy171
{
    class Solution
    {
        int titleToNumber(string s)
        {
            double res = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int n = (int)(s[s.Length - 1 - i]);
                res += (Math.Pow(26, i) * n);
            }
            return (int)res;
        }
    }
}
