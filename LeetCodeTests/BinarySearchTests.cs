using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchTest1()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.Search2(new int[] { -1, 0, 3, 5, 9, 12 }, 9);
            Assert.IsTrue(res == 4);
        }

        [TestMethod()]
        public void SearchTest2()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.Search2(new int[] { -1, 0, 3, 5, 9, 12 }, 2);
            Assert.IsTrue(res == -1);
        }

        [TestMethod()]
        public void SearchTest3()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.Search2(new int[] { 2, 5 }, 0);
            Assert.IsTrue(res == -1);
        }


        [TestMethod()]
        public void SearchTest2_1()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);
            Assert.IsTrue(res == 4);
        }

        [TestMethod()]
        public void SearchTest2_2()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);
            Assert.IsTrue(res == -1);
        }


        [TestMethod()]
        public void SearchInsertTest_1()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            Assert.IsTrue(res == 2);
        }

        [TestMethod()]
        public void SearchInsertTest_2()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            Assert.IsTrue(res == 1);
        }
        [TestMethod()]
        public void SearchInsertTest_3()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
            Assert.IsTrue(res == 4);
        }
        [TestMethod()]
        public void SearchInsertTest_4()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.SearchInsert(new int[] { 1, 3, 5, 6 }, 0);
            Assert.IsTrue(res == 0);
        }
        [TestMethod()]
        public void SearchInsertTest_5()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.SearchInsert(new int[] { 1 }, 0);
            Assert.IsTrue(res == 0);
        }

        [TestMethod()]
        public void SearchInsertTest_6()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.SearchInsert(new int[] { 1, 3 }, 0);
            Assert.IsTrue(res == 0);
        }

        [TestMethod()]
        public void SearchInsertTest_7()
        {
            BinarySearch binarySearch = new BinarySearch();
            int res = binarySearch.SearchInsert(new int[] { 3, 5, 7, 9, 10 }, 8);
            Assert.IsTrue(res == 3);
        }

    }
}