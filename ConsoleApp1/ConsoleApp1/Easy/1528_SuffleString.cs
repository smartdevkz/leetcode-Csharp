using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1528
{
    class Solution
    {
        public string RestoreString(string s, int[] indices)
        {
            var arr = new char[s.Length];
            for(int i = 0; i < indices.Length; i++)
            {
                arr[i] = s[indices[i]];
            }
            return String.Join("", arr);
        }
    }
}
