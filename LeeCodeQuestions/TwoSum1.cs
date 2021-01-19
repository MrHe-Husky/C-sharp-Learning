using System;
using System.Collections;

namespace TwoSum1
{
     class Program
     {
          static void Main(string[] args)
          {
               int[] nums = { 2, 3, 4 };
               int target = 6;
               Solution solution = new Solution();
               int[] backarray = solution.TwoSum(nums, target);
               Console.Write("{0} {1}", backarray[0], backarray[1]);
          }
     }

     //存在bug，当输入数组内存在两个相同数字时可能会有已存在键的情况。此时不可使用哈希表方法
     public class Solution
     {
          public int[] TwoSum(int[] nums, int target)
          {
               var hashtable = new Hashtable();
               for (int i = 0; i < nums.Length; i++)
               {
                    if (hashtable.ContainsKey(target - nums[i]))
                    {
                         return new int[] { (int)hashtable[target - nums[i]], i };
                    }
                    hashtable.Add(nums[i], i);
               }
               return new int[] { -1, -1 };
          }
     }
}
