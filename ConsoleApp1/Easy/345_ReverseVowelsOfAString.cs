using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy345
{
    class Solution
    {
        public string ReverseVowels(string s)
        {
            var builder = new StringBuilder();
            int i = 0, j = s.Length - 1;
            while (i < s.Length)
            {
                if (IsVowel(s[i]))
                {
                    if (IsVowel(s[j])) {
                        builder.Append(s[j]);
                        j--;
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }
                else
                {
                    builder.Append(s[i]);
                    i++;
                }
            }
            return builder.ToString();
        }

        private bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
        }
    }
}
