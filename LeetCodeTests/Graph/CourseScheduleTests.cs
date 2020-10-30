using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Graph.Tests
{
    [TestClass()]
    public class CourseScheduleTests
    {
        [TestMethod()]
        public void CanFinishTest()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[1][];
            pre[0] = new int[] { 0, 1 };
            bool res = courseSchedule.CanFinish(2, pre);
            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void CanFinishTest2()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[2][];
            pre[0] = new int[] { 0, 1 };
            pre[1] = new int[] { 1, 0 };
            bool res = courseSchedule.CanFinish(2, pre);
            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void CanFinishTest3()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[3][];
            pre[0] = new int[] { 0, 1 };
            pre[1] = new int[] { 0, 2 };
            pre[2] = new int[] { 1, 2 };
            bool res = courseSchedule.CanFinish(3, pre);
            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void CanFinishTest4()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[3][];
            pre[0] = new int[] { 0, 1 };
            pre[1] = new int[] { 1, 2 };
            pre[2] = new int[] { 2, 0 };
            bool res = courseSchedule.CanFinish(3, pre);
            Assert.IsFalse(res);
        }


        [TestMethod()]
        public void CanFinishTest6()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[2][];
            pre[0] = new int[] { 1, 0 };
            pre[1] = new int[] { 2, 1 };
            bool res = courseSchedule.CanFinish(3, pre);
            Assert.IsTrue(res);
        }

    }

    [TestClass()]
    public class CourseScheduleIITests
    {
        [TestMethod()]
        public void FindOrderTest()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[1][];
            pre[0] = new int[] { 1, 0 };
            int[] res = courseSchedule.FindOrder(2, pre);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1);
        }

        [TestMethod()]
        public void FindOrderTest2()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[4][];
            pre[0] = new int[] { 1, 0 };
            pre[1] = new int[] { 2, 0 };
            pre[2] = new int[] { 3, 1 };
            pre[3] = new int[] { 3, 2 };
            int[] res = courseSchedule.FindOrder(4, pre);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1 || res[1] == 2);
            Assert.IsTrue(res[2] == 1 || res[2] == 2);
            Assert.IsTrue(res[3] == 3);
        }

        [TestMethod()]
        public void FindOrderTest3()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[0][];
            //pre[0] = new int[0];
            int[] res = courseSchedule.FindOrder(1, pre);
            Assert.IsTrue(res[0] == 0);
        }

        [TestMethod()]
        public void FindOrderTest4()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[2][];
            pre[0] = new int[] { 0, 1 };
            pre[1] = new int[] { 1, 0 };
            int[] res = courseSchedule.FindOrder(2, pre);
            Assert.IsTrue(res.Length == 0);
        }

        [TestMethod()]
        public void FindOrderTest5()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[1][];
            pre[0] = new int[] { 0, 1 };
            int[] res = courseSchedule.FindOrder(2, pre);
            Assert.IsTrue(res[0] == 1);
            Assert.IsTrue(res[1] == 0);
        }

        [TestMethod()]
        public void FindOrderTest6()
        {
            CourseSchedule courseSchedule = new CourseSchedule();
            int[][] pre = new int[3][];
            pre[0] = new int[] { 1, 0 };
            pre[1] = new int[] { 1, 2 };
            pre[2] = new int[] { 0, 1 };
            int[] res = courseSchedule.FindOrder(3, pre);
            Assert.IsTrue(res.Length == 0);
        }


    }

}