using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarayTreeSearch230
{
     class Program
     {
          static void Main(string[] args)
          {
          }
     }
     /**
      * 二叉树搜索第k小的数字
      * */
     public class Solution
     {
          public int KthSmallest(TreeNode root, int k)
          {
               var numList = new List<int>();
               InOrderSearch(root,ref numList);

               Comparison<int> comparison = (x, y) => x - y;
               numList.Sort(comparison);

               return numList[k-1];
          }
          
          

          private void InOrderSearch(TreeNode node,ref List<int> numList)
          {
               if (node != null)
               {
                    InOrderSearch(node.left,ref numList);
                    numList.Add(node.val);
                    InOrderSearch(node.right, ref numList);
               }
          }

     }

     public class TreeNode
     {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
          {
               this.val = val;
               this.left = left;
               this.right = right;
          }
     }
}
