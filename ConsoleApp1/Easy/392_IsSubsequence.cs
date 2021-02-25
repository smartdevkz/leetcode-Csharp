using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy392
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            foreach (var c in s)
            {
                if (string.IsNullOrEmpty(t)) return false;
                var i = t.IndexOf(c);
                if (i == -1) return false;
                i++;
                t = i < t.Length ? t.Substring(i) : null;
            }
            return true;
        }
    }
}
