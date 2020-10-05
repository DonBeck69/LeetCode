using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class LongestSubstringTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest1()
        {
            LongestSubstring longestSubstring = new LongestSubstring();
            int res = longestSubstring.LengthOfLongestSubstring("abcabcbb");
            Assert.IsTrue(res == 3);
        }

        [TestMethod()]
        public void LengthOfLongestSubstringTest2()
        {
            LongestSubstring longestSubstring = new LongestSubstring();
            int res = longestSubstring.LengthOfLongestSubstring("bbbbbb");
            Assert.IsTrue(res == 1);
        }
        [TestMethod()]
        public void LengthOfLongestSubstringTest3()
        {
            LongestSubstring longestSubstring = new LongestSubstring();
            int res = longestSubstring.LengthOfLongestSubstring("pwwkew");
            Assert.IsTrue(res == 3);
        }
        [TestMethod()]
        public void LengthOfLongestSubstringTest4()
        {
            LongestSubstring longestSubstring = new LongestSubstring();
            int res = longestSubstring.LengthOfLongestSubstring("");
            Assert.IsTrue(res == 0);
        }

    }
}