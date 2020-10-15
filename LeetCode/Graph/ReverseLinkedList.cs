using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LeetCode.Graph
{
    public class ReverseLinkedList
    {

        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode res = new ListNode();
            Stack<int> stack = new Stack<int>();
            stack.Push(head.val);
            while (head.next != null)
            {
                stack.Push(head.next.val);
                head = head.next;
            }

            ListNode temp = res;
            while (stack.Count > 0)
            {
                temp.val = stack.Pop();
                if (stack.Count > 0)
                {
                    temp.next = new ListNode();
                    temp = temp.next;
                }
            }

            return res;
        }

        public ListNode reverseBetween(ListNode head, int m, int n)
        {
            if (head == null) return head;

            ListNode cur = head;
            ListNode prev = null;
            while (m > 1)
            {
                prev = cur;
                cur = cur.next;
                m--;
                n--;
            }

            ListNode con = prev;
            ListNode tail = cur;
            ListNode third = null;

            while (n > 0)
            {
                third = cur.next;
                cur.next = prev;
                prev = cur;
                cur = third;
                n--;
            }

            if (con != null)
            {
                con.next = prev;
            }
            else
            {
                head = prev;
            }

            tail.next = cur;

            return head;
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
