﻿using System;

namespace LeetCode
{
    public class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] A)
        {
            int[] res = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                res[i] = A[i] * A[i];
            }

            Array.Sort(res);
            return res;
        }
    }
}
