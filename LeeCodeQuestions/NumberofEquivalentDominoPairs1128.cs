using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberofEquivalentDominoPairs1128
{
     class Program
     {
          static void Main(string[] args)
          {
               int[][] dominoes = new int[4][];
               dominoes[0] = new int[] { 1, 2 };
               dominoes[1] = new int[] { 2, 1 };
               dominoes[2] = new int[] { 3, 4 };
               dominoes[3] = new int[] { 5, 6 };

               Console.WriteLine(new Solution().NumEquivDominoPairs(dominoes));
          }
     }

     public class Solution
     {
          public int NumEquivDominoPairs(int[][] dominoes)
          {
               int[] dominoesArr = new int[100];
               int EqualPairsNums = 0, tempPair = 0;
               for (int i = 0; i < dominoes.Length; i++)
               {
                    tempPair = dominoes[i][0] > dominoes[i][1] ? dominoes[i][0] * 10 + dominoes[i][1] : dominoes[i][1] * 10 + dominoes[i][0];
                    EqualPairsNums += dominoesArr[tempPair];
                    dominoesArr[tempPair]++;
               }
               return EqualPairsNums;
          }
     }
}
