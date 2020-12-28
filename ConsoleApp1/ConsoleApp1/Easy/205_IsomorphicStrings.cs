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
            for(int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i]) return false;
                }
                else
                {
                    if (dict.ContainsValue(t[i])) return false;
                    dict.Add(s[i], t[i]);
                }
            }
            return true;
        }
    }
}
