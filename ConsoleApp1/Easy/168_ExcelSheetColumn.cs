using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy168
{
    class Solution
    {
        public string ConvertToTitle(int n)
        {
            if (n <= 0) return "";
            if (n <= 26) return ((char)(n + 64)).ToString();
            var r = (n % 26);
            var d = n / 26;
            if (r == 0 && d > 0)
            {
                d--;
                r = 26;
            }
            var rStr = ((char)(r + 64)).ToString();
            if (d == 0) return rStr;
            return (d > 26 ? ConvertToTitle(d) : ((char)(d + 64)).ToString()) + rStr;
        }
    }
}
