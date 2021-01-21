using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddTwoNumbers2
{
     class Program
     {
          static void Main(string[] args)
          {
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

     public class Solution
     {
          public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
          {
               ListNode headNode = l1;
               while (l1.next!=null&&l2.next!=null)
               {
                    l1.val = l1.val + l2.val;
                    if (l1.val>=10)
                    {
                         l1.next.val++;
                         l1.val = l1.val % 10;
                    }
                    l1 = l1.next;
                    l2 = l2.next;
               }
               if (l1.next==null)
               {
                    l1.next = l2.next;
                    l2.next = null;
               }
               l1.val = l1.val + l2.val;
               if (l1.val < 10)
               {
                    return headNode;
               }
               do
               {
                    if (l1.next == null)
                    {
                         l1.val = l1.val % 10;
                         l1.next = new ListNode(1, null);
                         return headNode;
                    }
                    l1.val = l1.val % 10;
                    l1.next.val++;
                    l1 = l1.next;
               } while (l1.val == 10);
               return headNode;
          }
     }
}
