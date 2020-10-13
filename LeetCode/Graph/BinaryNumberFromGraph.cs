using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
/// </summary>
namespace LeetCode
{

    /// <summary>
    /// Graph Algo
    /// </summary>
    public class BinaryNumberFromGraph
    {
        public int GetDecimalValue(ListNode head)
        {
            int res = 0;
            string bin = string.Empty;
            GetNextVal(head, ref bin);
            res = Convert.ToInt32(bin, 2);
            return res;

        }

        public void GetNextVal(ListNode Node, ref string Bin)
        {
            Bin += Node.val;
            if (Node.next != null)
            {
                GetNextVal(Node.next, ref Bin);
            }
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
                 
        }
    }
}
