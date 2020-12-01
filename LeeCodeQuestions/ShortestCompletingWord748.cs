using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestCompletingWord748
{
     class Program
     {
          static void Main(string[] args)
          {
               string licensePlate = "1s3 PSt";
               string[] words = { "step", "steps", "stripe", "stepple" };
               var solution = new Solution();
               Console.WriteLine(solution.ShortestCompletingWord(licensePlate,words));
          }
     }

     public class Solution
     {
          public string ShortestCompletingWord(string licensePlate, string[] words)
          {
               string tempShortestWord = null;
               List<char> fixLicensePlate = new List<char>();
               licensePlate=licensePlate.ToLower();
               for (int i = 0; i < licensePlate.Length; i++)
               {
                    if (('0'<=licensePlate[i]&&licensePlate[i]<='9')||licensePlate[i]==' ')
                    {
                         continue;
                    }
                    fixLicensePlate.Add(licensePlate[i]);
               }
               foreach (var word in words)
               {
                    if (tempShortestWord!=null&&tempShortestWord.Length<=word.Length)
                    {
                         continue;
                    }
                    var tempCharArr = word.ToCharArray();
                    //检查单词中是否存在LicensePlate
                    bool checkedChar = true;
                    for (int i = 0; i <fixLicensePlate.Count; i++)
                    {
                         if (checkedChar)
                         {
                              checkedChar = false;
                              for (int j = 0; j < tempCharArr.Count(); j++)
                              {
                                   if (fixLicensePlate[i] == tempCharArr[j])
                                   {
                                        tempCharArr[j] = '0';
                                        checkedChar = true;
                                        if (i==fixLicensePlate.Count-1)
                                        {
                                             tempShortestWord = word;
                                        }
                                        break;
                                   }
                              }
                         }
                         else
                         {
                              break;
                         }
                    }
               }
               return tempShortestWord;
          }
     }
}
