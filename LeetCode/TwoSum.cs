using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// unsorted, use dixtionary and check if diff exists
    /// </summary>
    public class TwoSum
    {
        public int[] twoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            int value;


            Dictionary<int, int> indexes = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (indexes.TryGetValue(diff, out value))
                {
                    res[0] = value;
                    res[1] = i;
                    break;
                }
                else 
                {
                    if (indexes.ContainsKey(nums[i]) == false)
                    {
                        indexes.Add(nums[i], i);
                    }

                }
            }
            return res;
        }

        /// <summary>
        /// Winner, uses 2 step
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] twoSum2(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            int[] res = new int[2];
            int sum = 0;
            while (l < r)
            {
                sum = nums[l] + nums[r];
                if (sum == target)
                {
                    res[0] = l + 1;
                    res[1] = r + 1;
                    break;
                }
                else if (sum < target)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return res;
        }

    }
}
