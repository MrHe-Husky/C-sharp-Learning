using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPrimes204
{
     class Program
     {
          static void Main(string[] args)
          {
               int n = 499979;
               var solution = new Solution();
               Console.WriteLine(solution.CountPrimes(n));
          }
     }

     public class Solution
     {
          /**使用了位图方法*/
          public int CountPrimes(int n)
          {
               if (n<2)
               {
                    return 0;
               }
               int tempI, countPrimes = 0;
               var numArray = new BitArray(n+1);
               numArray.SetAll(true);
               numArray[0] = false;
               numArray[1] = false;
               for (int i = 0; i < n+1 ; i++)
               {
                    if (numArray[i])
                    {
                         tempI = i + i;
                         while (tempI < n + 1)
                         {
                              numArray[tempI] = false;
                              tempI += i;
                         }
                    }
               }
               foreach (bool item in numArray)
               {
                    if (item)
                    {
                         countPrimes++;
                    }
               }
               //坑爹的计算"小于"n的质数的要求
               if (numArray[n])
               {
                    countPrimes--;
               }
               return countPrimes;
          }
     }
}
