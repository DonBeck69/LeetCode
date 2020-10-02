using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class LargestTriangleAreaTests
    {
        [TestMethod()]
        public void LargestAreaTest()
        {
            LargestTriangleArea largestTriangleArea = new LargestTriangleArea();
            int[][] pts = new int[5][];
            pts[0] = new int[] { 0, 0 };
            pts[1] = new int[] { 0, 1 };
            pts[2] = new int[] { 1, 0 };
            pts[3] = new int[] { 0, 2 };
            pts[4] = new int[] { 2, 0 };
            double res = largestTriangleArea.LargestArea(pts);
            Assert.IsTrue(res == 1.9999999999999993);
        }

        [TestMethod()]
        public void LargestAreaTest1()
        {
            LargestTriangleArea largestTriangleArea = new LargestTriangleArea();
            int[][] pts = new int[3][];
            pts[0] = new int[] { 4, 6 };
            pts[1] = new int[] { 6, 5 };
            pts[2] = new int[] { 3, 1 };
            double res = largestTriangleArea.LargestArea(pts);
            Assert.IsTrue(res == 5.5);
        }

        [TestMethod()]
        public void LargestAreaTest2()
        {
            LargestTriangleArea largestTriangleArea = new LargestTriangleArea();
            int[][] pts = new int[5][];
            pts[0] = new int[] { 0, 0 };
            pts[1] = new int[] { 0, 1 };
            pts[2] = new int[] { 1, 0 };
            pts[3] = new int[] { 0, 3 };
            pts[4] = new int[] { 7, 0 };
            double res = largestTriangleArea.LargestArea(pts);
            Assert.IsTrue(res == 10.5);
        }

        //
        //[[-21,28],[-30,-49],[-48,47],[-22,-20],[19,3],[5,48]]
        [TestMethod()]
        public void LargestAreaTest3()
        {
            LargestTriangleArea largestTriangleArea = new LargestTriangleArea();
            int[][] pts = new int[6][];
            pts[0] = new int[] { -21, 28 };
            pts[1] = new int[] { -30, -49 };
            pts[2] = new int[] { -48, 47 };
            pts[3] = new int[] { -22, -20 };
            pts[4] = new int[] { 19, 3 };
            pts[5] = new int[] { 5, 48 };
            double res = largestTriangleArea.LargestArea(pts);
            Assert.IsTrue(res == 2820.00000);
        }

    }
}