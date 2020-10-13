using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FirstBadVersionTest()
        {
            Solution solution = new Solution();
            int res = solution.FirstBadVersion(8);
            Assert.IsTrue(res == 3);
        }
    }
}