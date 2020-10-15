using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    public class Invert
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if(root != null)
            {
                if(root.left != null)
                {
                    InvertTree(root.left);
                }
                if (root.right != null)
                {
                    InvertTree(root.right);
                }

                TreeNode node = root.right;
                root.right = root.left;
                root.left = node;
            }

            return root;
        }
    }
}
