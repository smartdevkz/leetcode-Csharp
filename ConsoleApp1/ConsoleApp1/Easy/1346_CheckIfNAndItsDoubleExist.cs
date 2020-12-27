using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1346
{
    class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            if (arr.Length < 2) return false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (IsExist(arr[i], arr[j])) return true;
                }
            }

            return false;
        }

        private bool IsExist(int a, int b)
        {
            if (a < 0 && b > 0) return false;
            if (b < 0 && a > 0) return false;
            if (a < 0) return IsExist((-1) * b, (-1) * a);
            if (a >= 0 && a < b) return IsExist(b, a);
            return b == (a - b);
        }
    }
}
