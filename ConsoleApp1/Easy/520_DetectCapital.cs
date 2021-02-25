using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy520
{
    class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            bool? allInUpperCase = null;
            bool? allInLowerCase = null;
            bool? isCapitalized = null;
            foreach (var c in word)
            {
                if (char.IsUpper(c))
                {
                    isCapitalized = isCapitalized == null ? true : false;
                    if (allInUpperCase == null) allInUpperCase = true;
                    allInLowerCase = false;
                }
                else
                {
                    if (isCapitalized == null) isCapitalized = false;
                    allInUpperCase = false;
                    if (allInLowerCase == null) allInLowerCase = true;
                }
            }
            return allInUpperCase.Value || allInLowerCase.Value || isCapitalized.Value;
        }
    }
}
