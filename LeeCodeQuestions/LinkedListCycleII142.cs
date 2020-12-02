using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCycleII142
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
          public ListNode(int x)
          {
               val = x;
               next = null;
          }
     }

     public class Solution
     {
          public ListNode DetectCycle(ListNode head)
          {
               if (head == null) return null;
               ListNode slowPoint = new ListNode(-1);
               ListNode fastPoint = new ListNode(-1);
               ListNode slowPoint1 = new ListNode(-1);
               slowPoint = head;
               fastPoint = head;
               slowPoint1 = head;
               //快指针一次移动2格，慢指针一次移动一格。
               do
               {
                    //快指针移动1
                    if (fastPoint.next == null)
                    {
                         return null;
                    }
                    fastPoint = fastPoint.next;
                    //快指针移动2
                    if (fastPoint.next == null)
                    {
                         return null;
                    }
                    fastPoint = fastPoint.next;
                    //慢指针移动1
                    slowPoint = slowPoint.next;
               } while (fastPoint != slowPoint);
               while (slowPoint != slowPoint1)
               {
                    slowPoint = slowPoint.next;
                    slowPoint1 = slowPoint1.next;
               }
               return slowPoint;
          }
     }
}