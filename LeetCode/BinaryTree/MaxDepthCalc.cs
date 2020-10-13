using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    public class MaxDepthCalc
    {
        public int MaxDepth(TreeNode root)
        {
            int max = 1;
            if (root != null)
            {
                max++;

                max = Math.Max(SearchTree(max, root.left), SearchTree(max, root.right));
            }
            return max;
        }

        public int SearchTree(int max, TreeNode tree)
        {
            if (tree != null)
            {
                max++;
                max = Math.Max(SearchTree(max, tree.left), SearchTree(max, tree.right));
            }

            return max;
        }
    }
}
