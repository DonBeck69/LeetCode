using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MajorityElements
    {

        /// <summary>
        /// sort and mid
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }


        /// <summary>
        /// moors voting
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement1(int[] nums)
        {
            int index = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[index])
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (count == 0)
                {
                    index = i;
                    count = 1;
                }
            }

            return nums[index];
        }

        /// <summary>
        /// hash map
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement2(int[] nums)
        {
            int res = 0;
            int count = 0;
            Dictionary<int, int> maxes = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (maxes.ContainsKey(num))
                {
                    maxes[num]++;
                }
                else
                {
                    maxes.Add(num, 1);
                }

                if (maxes[num] > count)
                {
                    res = num;
                    count = maxes[num];
                }
            }

            return res;
        }

        //public IList<int> MajorityElementII(int[] nums)
        //{
        //    int index = 0;
        //    int count = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == nums[index])
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            count--;
        //        }

        //        if (count == 0)
        //        {
        //            index = i;
        //            count = 1;
        //        }
        //    }

        //    return nums[index];
        //}
    }
}
