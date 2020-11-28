using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKFrequentWords692
{
     class Program
     {
          static void Main(string[] args)
          {
               string[] words = {"the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is"};
               int k = 4;
               Solution s = new Solution();
               s.TopKFrequent(words, k);
               Console.ReadKey();
          }
     }

     public class Solution
     {
          public IList<string> TopKFrequent(string[] words, int k)
          {
               IList<string> RList = new List<string>();
               Dictionary<string, int> wordDic = new Dictionary<string, int>();
               foreach (var word in words)
               {
                    if (wordDic.ContainsKey(word))
                    {
                         wordDic[word]++;
                    }
                    else
                    {
                         wordDic.Add(word, 1);
                    }
               }
               //想使用字典的OrderBy方法，不过无效而停止

               //Func<KeyValuePair<string, int>, int> keySelector = new Func<KeyValuePair<string, int>, int>(GetKeyValue);
               //wordDic.OrderBy(keySelector);
               //wordDic.OrderBy(keyValue => keyValue.Value);

               //Linq进行排序
               IEnumerable<KeyValuePair<string, int>> WordDDD =
                    from keyValue in wordDic
                    orderby keyValue.Value descending, keyValue.Key ascending
                    select keyValue;
               int i = 0;
               foreach (var dic in WordDDD)
               {
                    if (i < k)
                    {
                         Console.WriteLine("{0}-{1}",dic.Key,dic.Value);
                         RList.Add(dic.Key);
                         i++;
                    }
                    else break;
               }
               return RList;
          }
          /*委托方法(无法使用而废用)
          private int GetKeyValue(KeyValuePair<string, int> keyValue)
          {
               return keyValue.Value;
          }
          */
     }
}
