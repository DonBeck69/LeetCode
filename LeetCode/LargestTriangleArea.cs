using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LargestTriangleArea
    {
        public double LargestArea(int[][] points)
        {
            double res = 0;
            //double area = 0;
            int len = points.Length;
            for (int i = 0; i < len - 2; i++)
            {
                for(int j = i + 1; j < len - 1; j++)
                {
                    for(int k = j + 1; k < len; k++)
                    {
                        double newArea = TriangleArea(points[i], points[j], points[k]);
                        if (newArea > res)
                        {
                            res = newArea;
                        }
                    }
                }
            }

            return res;
        }

        public double TriangleArea(int[] one, int[] two, int[] three)
        {
            double res = 0;
            double x = HypotLength(Math.Abs(one[0] - two[0]), Math.Abs(one[1] - two[1]));
            double y = HypotLength(Math.Abs(two[0] - three[0]), Math.Abs(two[1] - three[1]));
            double h = HypotLength(Math.Abs(one[0] - three[0]), Math.Abs(one[1] - three[1]));
            double p = (x + y + h) / 2;
            res = Math.Sqrt(p * (p - x) * (p - y) * (p - h));
            return res;

        }

        public double HypotLength(int Y, int X)
        {
            return Math.Sqrt(Convert.ToDouble((Y * Y) + (X * X)));
        }
    }
}
