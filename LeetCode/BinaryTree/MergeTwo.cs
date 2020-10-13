using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    public class MergeTwo
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode treeNode = null;
            if (t1 != null && t2 != null)
            {
                treeNode = new TreeNode(t1.val + t2.val);
                treeNode.left = MergeTrees(t1.left, t2.left);
                treeNode.right = MergeTrees(t1.right, t2.right);
            }
            else if (t1 != null && t2 == null)
            {
                treeNode = new TreeNode(t1.val);
                treeNode.left = MergeTrees(t1.left, null);
                treeNode.right = MergeTrees(t1.right, null);
            }
            else if (t1 == null && t2 != null)
            {
                treeNode = new TreeNode(t2.val);
                treeNode.left = MergeTrees(null, t2.left);
                treeNode.right = MergeTrees(null, t2.right);
            }

            return treeNode;
        }
    }



}
