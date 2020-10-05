using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LeetCode
{
    public class LongestSubstring
    {
        /// <summary>
        /// Sliding window solution
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int res = 0;
            //hold unique chars
            HashSet<int> visited = new HashSet<int>();
            int l = 0; //left pointer
            int r = 0; //right pointer
            char[] chars = s.ToCharArray();
            //loop through chars, keep track of longest sub string
            while (r < chars.Length)
            {
                if (visited.Contains(chars[r]))
                {
                    visited.Remove(chars[l]);
                    l++;
                }
                else 
                {
                    visited.Add(chars[r]);
                    r++;
                    res = Math.Max(visited.Count, res);
                }

            }

            return res;
        }
    }
}
