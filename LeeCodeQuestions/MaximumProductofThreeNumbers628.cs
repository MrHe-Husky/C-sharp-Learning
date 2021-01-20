using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumProductofThreeNumbers628
{
     class Program
     {
          static void Main(string[] args)
          {
               int[] nums = { 2, 3, 4,4,-100 };
               Solution solution = new Solution();
               Console.Write(solution.MaximumProduct(nums));
          }
     }

     public class Solution
     {
          public int MaximumProduct(int[] nums)
          {
               int max1=int.MinValue, max2=int.MinValue, max3=int.MinValue, min1=int.MaxValue, min2=int.MaxValue;
               for (int i = 0; i < nums.Length; i++)
               {
                    if (nums[i]>max3)
                    {
                         if (nums[i]>max2)
                         {
                              if (nums[i]>max1)
                              {
                                   max3 = max2;
                                   max2 = max1;
                                   max1 = nums[i];
                              }
                              else
                              {
                                   max3 = max2;
                                   max2 = nums[i];
                              }
                         }
                         else
                         {
                              max3 = nums[i];
                         }
                    }
                    if (nums[i]<min2)
                    {
                         if (nums[i]<min1)
                         {
                              min2 = min1;
                              min1 = nums[i];
                         }
                         else
                         {
                              min2 = nums[i];
                         }
                    }
               }
               return Math.Max(max1*max2*max3,max1*min1*min2);
          }
     }
}
