using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class ModeInBinaryTreeTests
    {
        [TestMethod()]
        public void FindModeTest()
        {
            ModeInBinaryTree modeInBinaryTree = new ModeInBinaryTree();
            TreeNode node2l = new TreeNode(2);
            TreeNode node1r = new TreeNode(2, node2l, null);
            TreeNode node = new TreeNode(1, null, node1r);
            int[] res = modeInBinaryTree.FindMode2(node);
            Assert.IsTrue(res[0] == 2);
        }

        [TestMethod()]
        public void FindModeTest2()
        {
            ModeInBinaryTree modeInBinaryTree = new ModeInBinaryTree();
            TreeNode node2l = new TreeNode(2);
            TreeNode node1r = new TreeNode(2, node2l, null);
            TreeNode node1l = new TreeNode(1, null, null);
            TreeNode node = new TreeNode(1, node1l, node1r);
            int[] res = modeInBinaryTree.FindMode2(node);
            Assert.IsTrue(res[0] == 1);
            Assert.IsTrue(res[1] == 2);
        }

        [TestMethod()]
        public void FindModeTest3()
        {
            ModeInBinaryTree modeInBinaryTree = new ModeInBinaryTree();

            TreeNode node = new TreeNode(2147483647);
            int[] res = modeInBinaryTree.FindMode2(node);
            Assert.IsTrue(res[0] == 2147483647);
        }

    }
}