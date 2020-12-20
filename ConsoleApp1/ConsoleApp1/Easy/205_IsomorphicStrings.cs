using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy205
{
    class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], t[i]);
                }
                else
                {
                    if (dict[s[i]] != t[i]) return false;
                }
            }
            return true;
        }
    }
}
