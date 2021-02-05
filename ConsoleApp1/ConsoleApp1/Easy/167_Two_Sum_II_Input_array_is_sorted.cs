using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy167
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0) return null;
            if (target <= numbers[0]) return null;
            int i = 0, j = i + 1;
            while (i < numbers.Length-1)
            {
                if (j >= numbers.Length)
                {
                    i++;
                    j = i + 1;
                }
                if (numbers[i] + numbers[j] < target)
                {
                    j++;
                }
                else if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1 };
                }
                else
                {
                    i++;
                    j = i + 1;
                }
            }
            return null;
        }
    }
}
