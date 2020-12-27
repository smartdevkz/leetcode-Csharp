using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy278
{
    class Solution:VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 0;
            int right = n;
            while ((right - left) > 1)
            {
                var check = left + (right - left) / 2;
                if (base.IsBadVersion(check))
                {
                    right = check;
                }
                else
                {
                    left = check;
                }
            }
            return right;
        }
    }

    class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return version == 4;
        }
    }
}
