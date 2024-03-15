using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode listNode = new ListNode();
            ListNode listNode1 = new ListNode();
            //var list = listNode;
            //var list1 = listNode1;
            //for (int i =0;i<3;i++)
            //{
            //    list.val = 9;
            //    list.next = new ListNode(9);
            //    list = list.next;
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    list1.val = 9;
            //    list1.next = new ListNode(9);
            //    list1 = list1.next;
            //}
            listNode.val = 5;
            listNode1.val = 5;
            solution.AddTwoNumbers(listNode, listNode1);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode listNode = new ListNode();
            var list = listNode;
            int flag = 0; 
            while(l1 != null && l2 != null) 
            {
                int count = l1.val + l2.val + flag;
                int value = count % 10;
                flag = count / 10 > 0 ? 1 : 0;
                list.val = value;
                l1 = l1.next;
                l2 = l2.next;
                if(l1 != null && l2 != null)
                {
                    list.next = new ListNode();
                    list = list.next;
                }
            }
            if(l1 == null && l2 == null)
            {
                if (flag == 0) return listNode;
                else
                {
                    list.next = new ListNode(1);
                }
            }
            else if (l1 != null)
            {
                list.next = new ListNode();
                list = list.next;
                while(l1 != null)
                {
                    int count = l1.val + flag;
                    int value = count % 10;
                    flag = count / 10 > 0 ? 1 : 0;
                    list.val = value;
                    l1 = l1.next;
                    if (l1 != null)
                    {
                        list.next = new ListNode();
                        list = list.next;
                    }
                }
                if (flag == 0) return listNode;
                else
                {
                    list.next = new ListNode(1);
                }
            }
            else if(l2 != null)
            {
                list.next = new ListNode();
                list = list.next;
                while (l2 != null)
                {
                    int count = l2.val + flag;
                    int value = count % 10;
                    flag = count / 10 > 0 ? 1 : 0;
                    list.val = value;
                    l2 = l2.next;
                    if (l2 != null)
                    {
                        list.next = new ListNode();
                        list = list.next;
                    }
                }
                if (flag == 0) return listNode;
                else
                {
                    list.next = new ListNode(1);
                }
            }
            return listNode;
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
