using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Graph.Tests
{
    [TestClass()]
    public class ReverseLinkedListTests
    {
        [TestMethod()]
        public void ReverseListTest()
        {
            ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
            ListNode l5 = new ListNode(5);
            ListNode l4 = new ListNode(4, l5);
            ListNode l3 = new ListNode(3, l4);
            ListNode l2 = new ListNode(2, l3);
            ListNode l1 = new ListNode(1, l2);
            ListNode res = reverseLinkedList.ReverseList(l1);
            Assert.IsTrue(res.val == 5);
        }

        [TestMethod()]
        public void ReverseBetweenTest()
        {
            ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
            ListNode l5 = new ListNode(5);
            ListNode l4 = new ListNode(4, l5);
            ListNode l3 = new ListNode(3, l4);
            ListNode l2 = new ListNode(2, l3);
            ListNode l1 = new ListNode(1, l2);
            ListNode res = reverseLinkedList.reverseBetween(l1, 2, 4);
            Assert.IsTrue(res.next.val == 4);
        }

        [TestMethod()]
        public void ReverseBetweenTest2()
        {
            ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
            ListNode l6 = new ListNode(6);
            ListNode l8 = new ListNode(8, l6);
            ListNode l1 = new ListNode(1, l8);
            ListNode l10 = new ListNode(10, l1);
            ListNode l2 = new ListNode(2, l10);
            ListNode l9 = new ListNode(9, l2);
            ListNode l7 = new ListNode(7, l9);
            ListNode res = reverseLinkedList.reverseBetween(l7, 2, 5);
            Assert.IsTrue(res.next.next.val == 10);
        }

    }


}