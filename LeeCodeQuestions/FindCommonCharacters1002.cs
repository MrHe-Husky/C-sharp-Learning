using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommonCharacters1002
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine();
          }

          public class Solution
          {
               public IList<string> CommonChars(string[] A)
               {
                    List<char> intersection = A[0].ToList();
                    List<string> output = new List<string>();
                    foreach (var str in A)
                    {
                         GetIntersection(ref intersection, str);
                    }
                    foreach (var item in intersection)
                    {
                         output.Add(item.ToString());
                    }
                    return output;
               }

               //求交集
               public void GetIntersection(ref List<char> intersection, string str)
               {
                    bool matched = false;
                    //逐个扫描目前子集内的字符，如果在字符串内找不到相同字符则移除该字符
                    for (int j = 0; j < intersection.Count; j++)
                    {
                         for (int i = 0; i < str.Length; i++)
                         {
                              if (intersection[j] == str[i])
                              {
                                   str = str.Remove(i, 1);
                                   i--;
                                   matched = true;
                                   break;
                              }
                         }
                         if (!matched)
                         {
                              intersection.RemoveAt(j);
                              j--;
                         }
                         else
                         {
                              matched = false;
                         }
                    }
               }
          }
     }
}
