using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy605
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; ++i)
            {
                if (flowerbed[i] == 1) continue;
                if (i - 1 >= 0 && flowerbed[i - 1] == 1) continue;
                if (i + 1 < flowerbed.Length && flowerbed[i + 1] == 1) continue;
                n--;
                if(n==0)return true;
                i++;
            }
            return n <= 0;
        }
    }
}
