using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class GreatestCandiesTests
    {
        [TestMethod()]
        public void KidsWithCandiesTest()
        {
            GreatestCandies candies = new GreatestCandies();
            IList<bool> res = candies.KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);

            Assert.IsTrue(res[3] == false);
        }

        [TestMethod()]
        public void KidsWithCandiesTest2()
        {
            GreatestCandies candies = new GreatestCandies();
            IList<bool> res = candies.KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);

            Assert.IsTrue(res[0] == true);
        }

        [TestMethod()]
        public void KidsWithCandiesTest3()
        {
            GreatestCandies candies = new GreatestCandies();
            IList<bool> res = candies.KidsWithCandies(new int[] { 12, 1, 12 }, 10);

            Assert.IsTrue(res[1] == false);
        }


    }
}