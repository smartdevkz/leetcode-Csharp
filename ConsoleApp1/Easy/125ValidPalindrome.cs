using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy125
{
    class Solution
    {
        //125. Valid Palindrome
        public bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (!(Char.IsLetter(s[i]) || Char.IsDigit(s[i])))
                {
                    i++; continue;
                }
                if (!(Char.IsLetter(s[j]) || Char.IsDigit(s[j])))
                {
                    j--; continue;
                }
                if (Char.ToUpperInvariant(s[i]).Equals(Char.ToUpperInvariant(s[j])))
                {
                    i++; j--;
                }
                else
                {
                    break;
                }
            }
            return i >= j;
        }
    }
}
