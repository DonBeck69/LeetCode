using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree.Tests
{
    [TestClass()]
    public class MergeTwoTests
    {
        [TestMethod()]
        public void MergeTreesTest()
        {
            MergeTwo mergeTwo = new MergeTwo();
            TreeNode t15 = new TreeNode() { val = 5 };
            TreeNode t13 = new TreeNode() { val = 3, left = t15 };
            TreeNode t12 = new TreeNode() { val = 2 };
            TreeNode t1 = new TreeNode() { val = 1, left = t13, right = t12 };

            TreeNode t24 = new TreeNode() { val = 4 };
            TreeNode t27 = new TreeNode() { val = 7 };
            TreeNode t21 = new TreeNode() { val = 1, right = t24 };
            TreeNode t23 = new TreeNode() { val = 3, right = t27 };
            TreeNode t2 = new TreeNode() { val = 2, left = t21, right = t23 };

            TreeNode treeNode = mergeTwo.MergeTrees(t1, t2);

            Assert.IsTrue(treeNode.val == 3);
            Assert.IsTrue(treeNode.left.val == 4);
            Assert.IsTrue(treeNode.right.val == 5);
            Assert.IsTrue(treeNode.left.left.val == 5);
            Assert.IsTrue(treeNode.left.right.val == 4);

        }
    }
}