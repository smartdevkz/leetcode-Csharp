using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy771
{
    class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            if (J.Length == 0 || S.Length == 0) return 0;
            int k = S.Length;
            foreach (var c in J)
            {
                S = S.Replace(c.ToString(), "");
            }
            return k - S.Length;
        }
    }
}
