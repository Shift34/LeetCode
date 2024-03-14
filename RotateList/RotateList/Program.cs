using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode listNode = new ListNode();
            ListNode node = new ListNode(0, listNode) ;
            for (int i = 1 ; i < 2; i++)
            {
                listNode.val = i;
                listNode.next = new ListNode();
                
                listNode = listNode.next;
            }
            listNode.val = 2;
            solution.RotateRight(node, 4);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if(head == null)
            {
                return head;
            }
            int count = 1;
            ListNode listNode = head;
            ListNode node = head;
            while(listNode.next != null)
            {
                listNode = listNode.next;
                count++;
            }
            k %= count;
            if (k == 0)
            {
                return head;
            }
            for (int i = 0; i<count-k; i++)
            {
                node = node.next;
            }
            ListNode listNode1 = new ListNode(node.val,node.next);
            ListNode nod = listNode1;
            while (nod.next != null)
            {
                nod = nod.next;
            }
            ListNode node2 = head;
            for (int i = 0; i < count - k-1; i++)
            {
                node2 = node2.next;
            }
            node2.next = null;
            nod.next = head;
            return listNode1;
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

