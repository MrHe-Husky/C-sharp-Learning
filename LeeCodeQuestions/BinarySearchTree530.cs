using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree530
{
     class Program
     {
          static void Main(string[] args)
          {
          }
     }

     public class Solution
     {
          //作为中序遍历时的参数和计算最小绝对差值算法的类
          private class MinimumAbsoluteDifference
          {
               private int preNum;
               private int mini;
               public void update(int backNum)
               {
                    if (preNum == -1)
                    {
                         preNum = backNum;
                         return;
                    }
                    if (mini== -1)
                    {
                         mini = backNum - preNum;
                         preNum = backNum;
                         return;
                    }
                    //Console.WriteLine("{1}-{0}={2}", preNum, backNum, backNum - preNum);
                    if (mini>(backNum-preNum))
                    {
                         mini = backNum - preNum;
                         preNum = backNum;
                         return;
                    }
                    preNum = backNum;
               }
               public int getMinimumAbsoluteDifference()
               {
                    if (mini==-1||mini==0)
                    {
                         Console.WriteLine("error");
                         return -1;
                    }
                    return mini;
               }
               public MinimumAbsoluteDifference()
               {
                    preNum = -1;
                    mini = -1;
               }
          }

          public int GetMinimumDifference(TreeNode root)
          {
               if (root == null )
               {
                    return -1;
               }
               var minimumAbsoluteDifferencePara = new MinimumAbsoluteDifference();
               InOrderSearch(root,ref minimumAbsoluteDifferencePara);
               return minimumAbsoluteDifferencePara.getMinimumAbsoluteDifference();
          }
          private void InOrderSearch(TreeNode node,ref MinimumAbsoluteDifference para)
          {
               if (node != null)
               {
                    InOrderSearch(node.left,ref para);
                    para.update(node.val);
                    InOrderSearch(node.right, ref para);
               }
          }
     }

     public class TreeNode
     {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int x) { val = x; }
     }

}
