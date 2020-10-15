using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree.Tests
{
    [TestClass()]
    public class InvertTests
    {
        [TestMethod()]
        public void InvertTreeTest()
        {
            Invert invert = new Invert();
            TreeNode t1 = new TreeNode() { val = 1 };
            TreeNode t3 = new TreeNode() { val = 3 };
            TreeNode t2 = new TreeNode() { val = 2, left = t1, right = t3 };

            TreeNode t6 = new TreeNode() { val = 6 };
            TreeNode t9 = new TreeNode() { val = 9 };
            TreeNode t7 = new TreeNode() { val = 7, left = t6, right = t9 };
            TreeNode root = new TreeNode() { val = 4, left = t2, right = t7 };


            TreeNode res = invert.InvertTree(root);

            Assert.IsTrue(res.left.left.val == 9);
            Assert.IsTrue(res.right.val == 2);
        }
    }
}