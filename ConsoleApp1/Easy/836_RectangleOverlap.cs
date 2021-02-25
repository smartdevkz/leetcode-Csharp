using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy836
{
    public class Solution
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            //x:0,2
            //y:1,3
            return !((rec1[0] >= rec2[0] && rec1[0] >= rec2[2])
                || (rec1[2] <= rec2[0] && rec1[2] <= rec2[2])
                || (rec1[1] >= rec2[1] && rec1[1] >= rec2[3])
                || (rec1[3] <= rec2[1] && rec1[3] <= rec2[3]))
                && IsRectangle(rec1) && IsRectangle(rec2);
        }

        private bool IsRectangle(int[] rec)
        {
            return rec[0] != rec[2] && rec[1] != rec[3];
        }
    }
}
