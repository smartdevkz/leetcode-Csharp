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
            var dictVal = new Dictionary<char, char>();

            while (s.Length > 0 && t.Length > 0)
            {
                if (dict.ContainsKey(s[0]))
                {
                    if (dict[s[0]] != t[0]) return false;
                }
                else
                {
                    if (dictVal.ContainsKey(t[0])) return false;
                    dict.Add(s[0], t[0]);
                    dictVal.Add(t[0], s[0]);
                }
                s = s.Remove(0, 1);
                t = t.Remove(0, 1);
            }
            return true;
        }
    }
}
