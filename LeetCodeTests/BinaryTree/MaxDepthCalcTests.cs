using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree.Tests
{
    [TestClass()]
    public class MaxDepthCalcTests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            MaxDepthCalc mdc = new MaxDepthCalc();
            TreeNode t15 = new TreeNode() { val = 15 };
            TreeNode t7 = new TreeNode() { val = 7 };
            TreeNode t20 = new TreeNode() { val = 20,left = t15, right = t7 };
            TreeNode t9 = new TreeNode() { val = 9 };
            TreeNode t1 = new TreeNode() { val = 1, left = t9, right = t20 };


            int depth = mdc.MaxDepth(t1);

            Assert.IsTrue(depth == 3);
        }
    }
}