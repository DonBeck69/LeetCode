using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MoveZeroesArray
    {

        /// <summary>
        /// start at 1, look back one place, swap if 0.
        /// track swaps
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] MoveZeroes(int[] nums)
        {
            int zeroes = 0;
            if (nums[0] == 0)
            {
                zeroes++;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroes++;
                }
                if (nums[i - 1] == 0)
                {
                    if(nums[i] != 0)
                    {
                        int lookBack = Math.Max(1, zeroes);
                        nums[i - lookBack] = nums[i];
                        nums[i] = 0; // set it to... Zero
                    }
                }
            }

            return nums;
        }
    }
}
