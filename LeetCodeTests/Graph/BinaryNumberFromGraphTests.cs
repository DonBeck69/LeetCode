using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class BinaryNumberFromGraphTests
    {
        [TestMethod()]
        public void GetDecimalValueTest()
        {
            //1,0,1
            BinaryNumberFromGraph binaryNumberFromGraph = new BinaryNumberFromGraph();
            ListNode head = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 0,
                    next = new ListNode()
                    {
                        val = 1,
                        next = null
                    }
                }
            };

            int res = binaryNumberFromGraph.GetDecimalValue(head);
            Assert.IsTrue(res == 5);
        }
    }
}