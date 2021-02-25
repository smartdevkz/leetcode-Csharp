using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy557
{
    class Solution
    {
        public string ReverseWords(string s)
        {
            var builder = new StringBuilder();
            var wordBuilder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') wordBuilder.Insert(0, s[i]);
                else
                {
                    wordBuilder.Append(' ');
                    builder.Append(wordBuilder.ToString());
                    wordBuilder.Clear();

                }
            }
            if (wordBuilder.Length > 0) builder.Append(wordBuilder.ToString());
            return builder.ToString();
        }
    }
}
