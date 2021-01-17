using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1154
{
    public class Solution
    {
        public int DayOfYear(string date)
        {
            var arr = date.Split('-');
            int year = Convert.ToInt32(arr[0]);
            int month = Convert.ToInt32(arr[1]);
            int day = Convert.ToInt32(arr[2]);
            for (int i = 1; i < month; i++)
            {
                day += DateTime.DaysInMonth(year, i);
            }
            return day;
        }
    }
}
