using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class PalindromeNumberTests
    {
        [TestMethod()]
        public void IsPalindromeTest1()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(121);
            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void IsPalindromeTest2()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(-121);
            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void IsPalindromeTest3()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(10);
            Assert.IsFalse(res);
        }
        [TestMethod()]
        public void IsPalindromeTest4()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(11);
            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void IsPalindromeTest5()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(1);
            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void IsPalindromeTest6()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(123456554);
            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void IsPalindromeTest7()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(123454321);
            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void IsPalindromeTest8()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(0);
            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void IsPalindromeTest9()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(-1);
            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void IsPalindromeTest10()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(1001);
            Assert.IsTrue(res);
        }

        //
        [TestMethod()]
        public void IsPalindromeTest11()
        {
            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res = palindromeNumber.IsPalindrome(-2147483648);
            Assert.IsFalse(res);
        }

    }
}