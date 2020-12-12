using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1539
{
    class Solution
    {
        public int FindKthPositive(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0 || k < arr[0]) return k;
            int i = 0; int n = 1;
            while (i < arr.Length && k > 0)
            {
                if (arr[i] != n)
                {
                    k--;
                }
                else
                {
                    i++;
                }
                n++;
            }
            return k > 0 ? n + k - 1 : n-1;
        }
    }
}
