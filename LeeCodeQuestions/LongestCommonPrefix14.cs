using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubString
{
     class Program
     {
          static void Main(string[] args)
          {
               string[] strs = { "flower", "flow", "float"};
               Console.WriteLine(new Solution().LongestCommonPrefix(strs));
          }
     }

     public class Solution
     {
          /// <summary>
          /// 找出并返回最短子串
          /// Longest Common Prefix 14
          /// </summary>
          public string LongestCommonPrefix(string[] strs)
          {
               //输入只有0||1个字符串时
               if (strs.Length==0)
               {
                    return "";
               }
               if (strs.Length==1)
               {
                    return strs[0];
               }

               StringBuilder subString = new StringBuilder(strs[0]);
               int shorterLength;
               for (int i = 1; i < strs.Length; i++)
               {
                    if (strs[i].Length==0)
                    {
                         return "";
                    }
                    if (subString.Length > strs[i].Length)
                    {
                         shorterLength = strs[i].Length;
                         subString.Remove(strs[i].Length, subString.Length - strs[i].Length );
                    }
                    else
                    {
                         shorterLength = subString.Length;
                    }
                    for (int j = 0; j < shorterLength; j++)
                    {
                         if (subString[j]!=strs[i][j])
                         {
                              subString.Remove(j, subString.Length - j);
                              break;
                         }
                    }
                    if (subString.Length==0)
                    {
                         return "";
                    }
               }
               return subString.ToString();
          }
     }
}
