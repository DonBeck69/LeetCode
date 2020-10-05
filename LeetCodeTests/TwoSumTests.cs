using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class TwoSumTests
    {
        [TestMethod()]
        public void twoSumTest()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { 2, 7, 11, 15 }, 9);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1);
        }

        [TestMethod()]
        public void twoSumTest2()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { 3, 2, 4 }, 6);
            Assert.IsTrue(res[0] == 1);
            Assert.IsTrue(res[1] == 2);
        }

        [TestMethod()]
        public void twoSumTest3()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { 3, 3 }, 6);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1);
        }

        [TestMethod()]
        public void twoSumTest4()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { 3, 2, 3 }, 6);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 2);
        }
        [TestMethod()]
        public void twoSumTest5()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { 0, 4, 3, 0 }, 7);
            Assert.IsTrue(res[0] == 1);
            Assert.IsTrue(res[1] == 2);
        }
        [TestMethod()]
        public void twoSumTest6()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { -3, 4, 3, 90 }, 0);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 2);
        }
        [TestMethod()]
        public void twoSumTest7()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { 2, 5, 5, 11}, 10);
            Assert.IsTrue(res[0] == 1);
            Assert.IsTrue(res[1] == 2);
        }

        [TestMethod()]
        public void twoSumTest8()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { 0, 4, 3, 0 }, 0);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 3);
        }



        [TestMethod()]
        public void twoSumTestD()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum(new int[] { 11, 15, 7, 5, 4, 3 }, 9);
            Assert.IsTrue(res[0] == 3);
            Assert.IsTrue(res[1] == 4);
        }

        //### Two Sum II

        [TestMethod()]
        public void twoSumTest2_1()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum2(new int[] { 2, 7, 11, 15 }, 9);
            Assert.IsTrue(res[0] == 1);
            Assert.IsTrue(res[1] == 2);
        }

        [TestMethod()]
        public void twoSumTest2_2()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum2(new int[] { 2, 3, 4 }, 6);
            Assert.IsTrue(res[0] == 1);
            Assert.IsTrue(res[1] == 3);
        }

        [TestMethod()]
        public void twoSumTest2_3()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum2(new int[] { -1, 0 }, -1);
            Assert.IsTrue(res[0] == 1);
            Assert.IsTrue(res[1] == 2);
        }

        [TestMethod()]
        public void twoSumTest2_4()
        {
            TwoSum twoSum = new TwoSum();
            int[] res = twoSum.twoSum2(new int[] { 5, 25, 75 }, 100);
            Assert.IsTrue(res[0] == 2);
            Assert.IsTrue(res[1] == 3);
        }


    }
}