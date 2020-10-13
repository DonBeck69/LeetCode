using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// https://leetcode.com/problems/minimum-number-of-vertices-to-reach-all-nodes/
/// </summary>
namespace LeetCode.Graph
{
    public class MinimumVertaciesNodes
    {
        public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            HashSet<int> results = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                results.Add(i);
            }

            for (int j = 0; j < edges.Count; j++)
            {
                results.Remove(edges[j][1]);
            }

            return results.ToList();
        }
    }
}
