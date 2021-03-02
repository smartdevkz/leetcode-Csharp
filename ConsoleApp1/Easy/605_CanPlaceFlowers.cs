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
            int k = 0;
            bool prevIsEmpty = true;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if (prevIsEmpty)
                    {
                        if (i + 1 >= flowerbed.Length || flowerbed[i + 1] == 0)
                        {
                            k++;
                            if (k >= n) return true;
                        }
                        else
                        {
                            prevIsEmpty = false;
                        }
                        i++;
                    }
                    else
                    {
                        prevIsEmpty = true;
                    }
                }
                else
                {
                    prevIsEmpty = false;
                }
            }
            return false;
        }
    }
}
