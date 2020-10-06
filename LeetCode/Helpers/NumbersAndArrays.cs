using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Helpers
{
    public class NumbersAndArrays
    {

        public long[] NumberToArray(long Number)
        {
            long digets = Convert.ToInt32(Math.Floor(Math.Log10(Math.Abs(Number)) + 1));
            long[] result = new long[digets];
            bool IsNegative = Number < 0;
            Number = Math.Abs(Number);
            for (int index = result.Length - 1; index >= 0; index--)
            {
                result[index] = Math.Abs(Number) % 10;
                Number /= 10;
            }

            if (IsNegative)
            {
                result[result.Length - 1] = -result[result.Length - 1];
            }

            return result;
        }

        public int ArrayToNumber(int[] NumberArray)
        {
            int result = 0;
            int digitCount = 1;
            for (int index = NumberArray.Length - 1; index >= 0; index--)
            {
                result += NumberArray[index] * digitCount;
                digitCount *= 10;
            }

            return result;
        }

    }
}
