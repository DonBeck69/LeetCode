using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Helpers;

namespace LeetCode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            NumbersAndArrays naa = new NumbersAndArrays();
            bool res = true;

            if (x < 10 && x >= 0)
            {
                return true;
            }

            if (x < 0 && x > -10)
            {
                return false;
            }

            long[] numbers = naa.NumberToArray(Convert.ToInt64(x));
            int len = numbers.Length;

            int l = 0;
            int r = numbers.Length - 1;
            while (l < len / 2)
            {
                if (numbers[l++] != numbers[r--])
                {
                    return false;
                }
            }

            return res;
        }
    }
}
