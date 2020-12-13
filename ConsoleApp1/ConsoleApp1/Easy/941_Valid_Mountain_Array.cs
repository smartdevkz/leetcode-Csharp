using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy941
{
    class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 2) return false;
            if (arr[0] >= arr[1]) return false;
            bool hasPeaked = false;
            for (int i = 1; i < arr.Length; i++)
            {
                if (hasPeaked)
                {
                    if (arr[i] >= arr[i - 1]) return false;
                }
                else
                {
                    if (arr[i] <= arr[i - 1])
                    {
                        if (arr[i] < arr[i - 1]) { hasPeaked = true; continue; }
                        return false;
                    }
                }

            }
            return hasPeaked && true;
        }
    }
}
