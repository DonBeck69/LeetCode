using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Graph.Tests
{
    [TestClass()]
    public class MinimumVertaciesNodesTests
    {
        [TestMethod()]
        public void FindSmallestSetOfVerticesTest()
        {
            MinimumVertaciesNodes minimumVertaciesNodes = new MinimumVertaciesNodes();
            IList<IList<int>> edges = new List<IList<int>>();
            edges.Add(new List<int>() { 0, 1 });
            edges.Add(new List<int>() { 0, 2 });
            edges.Add(new List<int>() { 2, 5 });
            edges.Add(new List<int>() { 3, 4 });
            edges.Add(new List<int>() { 4, 2 });

            IList<int> res = minimumVertaciesNodes.FindSmallestSetOfVertices(6, edges);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 3);
        }
    }
}