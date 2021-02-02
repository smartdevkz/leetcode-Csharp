using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy217
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hs = new HashSet<int>();
            foreach(var item in nums)
            {
                if (hs.Contains(item))
                {
                    return true;
                }
                else
                {
                    hs.Add(item);
                }
            }
            return false;
        }
    }
}
