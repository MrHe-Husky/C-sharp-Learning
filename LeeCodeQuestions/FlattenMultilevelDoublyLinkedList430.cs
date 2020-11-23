using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenMultilevelDoublyLinkedList430
{
     class Program
     {
          static void Main(string[] args)
          {
          }
     }

     public class Solution
     {
          public Node Flatten(Node head)
          {
               if (head == null)
               {
                    return head;
               }
               Stack<Node> branchNode = new Stack<Node>();
               Node PNode = head;
               Node tempNode;
               while (!(PNode.next == null && branchNode.Count == 0&&PNode.child==null)) 
               {
                    //有孩子节点
                    if (PNode.child!=null)
                    {
                         if (PNode.next!=null)
                         {
                              branchNode.Push(PNode.next);
                         }
                         tempNode = PNode;
                         PNode.next = PNode.child;
                         PNode = PNode.next;
                         PNode.prev = tempNode;
                         tempNode.child = null;
                         continue;
                    }
                    //下一个节点为空，要跳回上一段链表
                    if (PNode.next==null&&branchNode.Count!=0)
                    {
                         tempNode = PNode;
                         PNode.next = branchNode.Pop();
                         PNode = PNode.next;
                         PNode.prev = tempNode;
                         continue;
                    }
                    //非以上情况，在本链表中继续
                    if (PNode.next!=null)
                    {
                         PNode = PNode.next;
                         continue;
                    }
               }
               return head;
          }
     }

     public class Node
     {
          public int val;
          public Node prev;
          public Node next;
          public Node child;
     }
}
