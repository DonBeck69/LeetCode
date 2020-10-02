using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class XofAKindDeckTests
    {


        //

        [TestMethod()]
        public void HasGroupsSizeXTest()
        {
            XofAKindDeck deck = new XofAKindDeck();
            bool res = deck.HasGroupsSizeX(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 });
            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void HasGroupsSizeXTest2()
        {
            XofAKindDeck deck = new XofAKindDeck();
            bool res = deck.HasGroupsSizeX(new int[] { 1, 1, 1, 2, 2, 2, 3, 3 });
            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void HasGroupsSizeXTest3()
        {
            XofAKindDeck deck = new XofAKindDeck();
            bool res = deck.HasGroupsSizeX(new int[] { 1 });
            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void HasGroupsSizeXTest4()
        {
            XofAKindDeck deck = new XofAKindDeck();
            bool res = deck.HasGroupsSizeX(new int[] { 1, 1 });
            Assert.IsTrue(res);
        }


        [TestMethod()]
        public void HasGroupsSizeXTest5()
        {
            XofAKindDeck deck = new XofAKindDeck();
            bool res = deck.HasGroupsSizeX(new int[] { 1, 1, 2, 2, 2, 2 });
            Assert.IsTrue(res);
        }

        //[1,1,1,1,2,2,2,2,2,2]
        [TestMethod()]
        public void HasGroupsSizeXTest6()
        {
            XofAKindDeck deck = new XofAKindDeck();
            bool res = deck.HasGroupsSizeX(new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 });
            Assert.IsTrue(res);
        }

    }
}