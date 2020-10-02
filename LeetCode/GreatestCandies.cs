using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class GreatestCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] res = new bool[candies.Length];
            int max = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                res[i] =candies[i] + extraCandies >= max;
            }
            return res.ToList();
        }

        public IList<bool> KidsWithCandies2(int[] candies, int extraCandies)
        {
            List<bool> res = new List<bool>();
            int max = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                res.Add(candies[i] + extraCandies >= max);
            }
            return res;
        }

    }
}
