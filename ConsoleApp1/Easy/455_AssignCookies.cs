using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy455
{
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int i = 0;
            for (int j = 0; i < g.Length && j < s.Length; j++)
            {
                if (g[i] <= s[j]) i++;
            }
            return i;
        }
    }
}
