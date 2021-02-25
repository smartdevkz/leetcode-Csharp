using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1684
{
    public class Solution
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int k = words.Length;
            foreach (var w in words)
            {
                foreach (var c in w)
                {
                    if (!allowed.Contains(c))
                    {
                        k--;
                        break;
                    }
                }
            }
            return k;
        }
    }
}
