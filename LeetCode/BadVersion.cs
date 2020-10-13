using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

    public class BadVersion
    {
        private bool[] _version = new bool[] { false, false, false, true, true, true, true, true };

        public bool IsBadVersion(int index)
        {
            return _version[index];
        }
    }

    public class Solution : BadVersion
    {
        public int FirstBadVersion(int n)
        {
            int left = 0;
            int right = n;
            int mid;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}
