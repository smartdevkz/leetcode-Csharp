using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy389
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            foreach(var c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach(var c in t)
            {
                if (dict.ContainsKey(c))
                {
                    if (dict[c] == 0) return c;
                    dict[c]--;
                }
                else
                {
                    return c;
                }
            }
            return ' ';
        }
    }
}
