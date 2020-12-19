using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy541
{
    class Solution
    {
        public string ReverseStr(string s, int k)
        {
            var builder = new StringBuilder();
            bool isReverse = true;
            string temp = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (isReverse)
                    temp = s[i] + temp;
                else
                    temp += s[i];
                if ((i + 1) % k == 0)
                {
                    isReverse = !isReverse;

                    if (isReverse)
                    {
                        builder.Append(temp);
                        temp = string.Empty;
                    }
                }
            }
            if (!string.IsNullOrEmpty(temp)) builder.Append(temp);
            return builder.ToString();
        }
    }
}
