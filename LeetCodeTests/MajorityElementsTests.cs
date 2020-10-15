using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class MajorityElementsTests
    {
        [TestMethod()]
        public void MajorityElementTest()
        {
            MajorityElements majorityElements = new MajorityElements();
            int[] nums = new int[] { 3, 2, 3 };
            int res = majorityElements.MajorityElement(nums);
            Assert.IsTrue(res == 3);
        }
    }
}