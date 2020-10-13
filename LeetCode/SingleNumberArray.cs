using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class SingleNumberArray
    {
        /// <summary>
        /// XOR (Exclusive or)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber1(int[] nums)
        {
            int a = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                a ^= nums[i];
            }

            return a;
        }


        public int SingleNumber(int[] nums)
        {
            HashSet<int> found = new HashSet<int>();
            found.Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (found.Remove(nums[i]) == false)
                {
                    found.Add(nums[i]);
                }
            }

            return found.First();
        }

        public int SingleNumber2(int[] nums)
        {
            int res = 0;
            Array.Sort(nums);
            for (int i = 1; i <= nums.Length; i += 2)
            {
                if (i < nums.Length)
                {
                    if (nums[i - 1] != nums[i])
                    {
                        res = nums[i - 1];
                        break;
                    }
                }
                else
                {
                    res = nums[i - 1];
                    break;
                }
            }

            return res;
        }
    }
}
