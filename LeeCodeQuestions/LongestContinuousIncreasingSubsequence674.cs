using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestContinuousIncreasingSubsequence674
{
     class Program
     {
          static void Main(string[] args)
          {
               int[] numArray = {1,3,5,7，5,7};
               Console.WriteLine("{0}",new Solution().FindLengthOfLCIS(numArray));
          }
     }

     public class Solution
     {
          public int FindLengthOfLCIS(int[] nums)
          {
               int longestQueue = 0;
               int tempIncreasingQueue = 0;
               int preNum = int.MinValue;
               for (int i = 0; i < nums.Length; i++)
               {
                    if (nums[i]>preNum)
                    {
                         tempIncreasingQueue++;
                         preNum = nums[i];
                    }
                    else
                    {
                         if (tempIncreasingQueue>longestQueue)
                         {
                              longestQueue = tempIncreasingQueue;
                         }
                         tempIncreasingQueue = 1;
                         preNum = nums[i];
                    }
               }
               if (tempIncreasingQueue>longestQueue)
               {
                    longestQueue = tempIncreasingQueue;
               }
               return longestQueue;
          }
     }
}
