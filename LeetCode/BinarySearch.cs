using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BinarySearch
    {
        /// <summary>
        /// Recursive
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search2(int[] nums, int target)
        {
            return binSearch(0, nums.Length - 1, ref nums, ref target);
        }






        public int binSearch(int start, int end, ref int[] nums, ref int target)
        {
            int res = -1;
            if (start <= end)
            {
                if (start == end)
                {
                    if (nums[start] == target)
                    {
                        return start;
                    }
                    else
                    {
                        return -1;
                    }
                }

                int mid = ((end - start) / 2) + start;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    res = binSearch(mid + 1, end, ref nums, ref target);
                }
                else if (nums[mid] > target)
                {
                    res = binSearch(start, mid - 1, ref nums, ref target);
                }
            }
            return res;
        }

        public int SearchInsert(int[] nums, int target)
        {
            return binSearchInsert(0, nums.Length - 1, ref nums, ref target);
        }

        public int binSearchInsert(int start, int end, ref int[] nums, ref int target)
        {
            int res = start;
            if (start <= end)
            {
                if (start == end)
                {
                    if (nums[start] == target)
                    {
                        return start;
                    }
                    else if (nums[start] < target)
                    {
                        return start + 1;
                    }
                    else
                    {
                        return start;
                    }
                }

                int mid = ((end - start) / 2) + start;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    res = binSearchInsert(mid + 1, end, ref nums, ref target);
                }
                else if (nums[mid] > target)
                {
                    res = binSearchInsert(start, mid - 1, ref nums, ref target);
                }
            }
            return res;
        }




        //not recusive
        public int Search(int[] nums, int target)
        {
            int res = -1;
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;// ((end - start) / 2) + start;
            while (start <= end)
            {
                mid = ((end - start) / 2) + start;
                if (nums[mid] == target)
                {
                    res = mid;
                    break;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }

            return res;
        }
    }
}
