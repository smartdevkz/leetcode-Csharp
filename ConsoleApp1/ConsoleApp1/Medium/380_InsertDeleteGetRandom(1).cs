using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium380
{
    public class RandomizedSet
    {
        private List<int> lst = null;
        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            lst = new List<int>();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (lst.Contains(val))
            {
                return false;
            }
            else
            {
                lst.Add(val);
                return true;
            }
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (lst.Contains(val))
            {
                lst.Remove(val);
                return true;
            }
            else
            {
                return false;
            }
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            if (lst.Count == 0) return 0;
            Random rnd = new Random();
            return lst[rnd.Next(0, lst.Count)];
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
