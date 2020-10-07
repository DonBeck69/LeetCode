using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ModeInBinaryTree
    {
        public int[] FindMode2(TreeNode root)
        {
            if (root == null)
            {
                return new int[0];
            }
            List<int> allResults = new List<int>();
            List<int> results = new List<int>();
            Dictionary<int, int> modes = new Dictionary<int, int>();
            Ent(root, modes);
            int max = 0;
            foreach(KeyValuePair<int, int> mode in modes)
            {
                //max = mode.Value;
                if (mode.Value == max)
                {
                    results.Add(mode.Key);
                    max = mode.Value;
                }
                if (mode.Value > max)
                {
                    results.Clear();
                    results.Add(mode.Key);
                    max = mode.Value;
                }

            }
            
            return results.ToArray();

        }

        public int[] FindMode(TreeNode root)
        {
            if (root == null)
            {
                return new int[0];
            }
            List<int> allResults = new List<int>();
            List<int> results = new List<int>();
            Dictionary<int, int> modes = new Dictionary<int, int>();
            Ent(root, modes);
            modes = modes.OrderBy(v => v.Value).ToDictionary(k => k.Key, v => v.Value);

            results.Add(modes.Last().Key);
            if (modes.Count > 1)
            {
                for (int i = modes.Count - 2; i >= 0; i--)
                {
                    if (modes.ElementAt(i).Value == modes.Last().Value)
                    {
                        results.Add(modes.ElementAt(i).Key);
                    }
                }
            }

            return results.ToArray();

        }

        public void Ent(TreeNode node, Dictionary<int, int> modes)
        {
            if (node != null)
            {
                if (modes.ContainsKey(node.val))
                {
                    modes[node.val]++;
                }
                else
                {
                    modes.Add(node.val, 1);
                }

                Ent(node.left, modes);
                Ent(node.right, modes);
                
            }
        }
    }
}


 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
