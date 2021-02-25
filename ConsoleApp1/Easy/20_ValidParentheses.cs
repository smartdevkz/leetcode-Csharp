using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            int prevLen = 0;
            do
            {
                prevLen = s.Length;
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");                
            } while (prevLen != s.Length);
            return s.Length == 0;
        }
    }
}
