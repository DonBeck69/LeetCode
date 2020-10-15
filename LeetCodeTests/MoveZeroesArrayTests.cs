using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class MoveZeroesArrayTests
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            MoveZeroesArray mz = new MoveZeroesArray();
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            nums = mz.MoveZeroes(nums);
            Assert.IsTrue(nums[3] == 0);
        }

        //[1,0,0,1]
        [TestMethod()]
        public void MoveZeroesTest2()
        {
            MoveZeroesArray mz = new MoveZeroesArray();
            int[] nums = new int[] { 1, 0, 0, 1 };
            nums = mz.MoveZeroes(nums);
            Assert.IsTrue(nums[3] == 0);
        }

    }
}