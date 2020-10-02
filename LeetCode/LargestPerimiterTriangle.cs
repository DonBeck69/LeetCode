using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LargestPerimiterTriangle
    {
        public int LargestPerimeter(int[] A)
        {
            int res = 0;
            Array.Sort(A);
            int i = A.Length - 1;

            while (i > 1)
            {
                if(A[i - 2] + A[i - 1] <= A[i])
                {
                    i--;
                }
                else
                {
                    res = A[i - 2] + A[i - 1] + A[i];
                    break;
                }
            }

            return res;
        }
    }
}
