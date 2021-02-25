using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hard42
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            int res = 0;
            int k = 0;
            int sum = getSum(height, k);
            while (sum !=-1)
            {
                res += sum;
                sum = getSum(height, ++k);
            }
            return res;
        }

        int getSum(int[] arr, int k)
        {
            int res = 0;
            int sum = 0;
            bool start = false;
            bool hasPositiveValue = false;
            for(int i=0;i<arr.Length;i++)
            {
                var val = arr[i] - k;
                if (val > 0) hasPositiveValue = true;
                if (val > 0)
                {
                    if (!start)
                    {
                        start = true;
                        sum = 0;
                    }
                    else
                    {
                        res += sum;
                        sum = 0;
                    }
                }
                else
                {
                    if (start)
                    {
                        sum++;
                    }
                }
            }
            if (!hasPositiveValue) return -1;
            return res;
        }
    }
}
