using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy728
{
    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> lst = new List<int>();
            for(int i = left; i <= right; i++)
            {
                if (IsSelfDividing(i)) lst.Add(i);
            }
            return lst;
        }

        private bool IsSelfDividing(int n)
        {
            if (n / 10 == 0) return true;
            var origin = n;
            while (n > 0)
            {
                int d = n % 10;
                if (d == 0 || origin % d != 0) return false;
                n = n / 10;
            }
            return true;
        }
    }
}
