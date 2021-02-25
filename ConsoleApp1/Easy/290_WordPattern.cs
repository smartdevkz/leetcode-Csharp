using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy290
{
    class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            var arr = s.Split(' ');
            if (pattern.Length != arr.Length) return false;
            var dict = new Dictionary<char, string>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]))
                {
                    if (dict[pattern[i]] != arr[i]) return false;
                }
                else
                {
                    if (dict.ContainsValue(arr[i])) return false;
                    dict.Add(pattern[i], arr[i]);
                }
            }
            return true;
        }
    }
}
