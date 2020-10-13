using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class SingleNumberArrayTests
    {
        [TestMethod()]
        public void SingleNumberTest1()
        {
            SingleNumberArray singleNumberArray = new SingleNumberArray();
            int[] nums = new int[] { 2, 2, 1 };
            int res = singleNumberArray.SingleNumber(nums);
            Assert.IsTrue(res == 1);
        }
        [TestMethod()]
        public void SingleNumberTest2()
        {
            SingleNumberArray singleNumberArray = new SingleNumberArray();
            int[] nums = new int[] { 4, 1, 2, 1, 2 };
            int res = singleNumberArray.SingleNumber(nums);
            Assert.IsTrue(res == 4);
        }
        [TestMethod()]
        public void SingleNumberTest3()
        {
            SingleNumberArray singleNumberArray = new SingleNumberArray();
            int[] nums = new int[] { 1 };
            int res = singleNumberArray.SingleNumber(nums);
            Assert.IsTrue(res == 1);
        }

    }


}