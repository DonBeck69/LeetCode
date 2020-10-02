using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode
{
    public class XofAKindDeck
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            bool res = true;

            //Just no...
            if (deck.Length <= 1)
            {
                return false;
            }


            //create a map of numbers and the number of times they appear.
            Dictionary<int, int> nums = new Dictionary<int, int>();

            // use GCD (greatest common devisor) or Euclidean Algorithm
            for (int i = 0; i < deck.Length; i++)
            {
                if(nums.ContainsKey(deck[i]) == false)
                {
                    nums.Add(deck[i], 1);
                }
                else
                {
                    nums[deck[i]]++;
                }
            }


            int gcd = 0;
            foreach(int value in nums.Values)
            {
                gcd = getGCD(gcd, value);
            }


            return (gcd > 1);
        }

        public int getGCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }

            return getGCD(b % a, a);
        }

    }
}

/*
            for (int i = 0; i < deck.Length; i++)
            {
                if(nums.ContainsKey(deck[i]) == false)
                {
                    nums.Add(deck[i], 1);
                }
                else
                {
                    nums[deck[i]]++;
                }
            }

 */
