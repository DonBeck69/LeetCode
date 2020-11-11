using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class LargestPerimiterTriangleTests
    {
        [TestMethod()]
        public void LargestPerimeterdTest()
        {
            LargestPerimiterTriangle largestPerimiterTriangle = new LargestPerimiterTriangle();
            int res = largestPerimiterTriangle.LargestPerimeter(new int[] { 2, 1, 2 });
            Assert.IsTrue(res == 5);
        }
        [TestMethod()]
        public void LargestPerimeterdTest1()
        {
            LargestPerimiterTriangle largestPerimiterTriangle = new LargestPerimiterTriangle();
            int res = largestPerimiterTriangle.LargestPerimeter(new int[] { 1, 2, 1});
            Assert.IsTrue(res == 0);
        }

        [TestMethod()]
        public void LargestPerimeterdTest2()
        {
            LargestPerimiterTriangle largestPerimiterTriangle = new LargestPerimiterTriangle();
            int res = largestPerimiterTriangle.LargestPerimeter(new int[] { 3, 6, 2, 3 });
            Assert.IsTrue(res == 8);
        }

        [TestMethod()]
        public void LargestPerimeterdTest3()
        {
            LargestPerimiterTriangle largestPerimiterTriangle = new LargestPerimiterTriangle();
            int res = largestPerimiterTriangle.LargestPerimeter(new int[] { 1, 2, 2, 4, 18, 8 });
            Assert.IsTrue(res == 5);
        }
    }
}