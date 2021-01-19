using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEnd1436
{
     class Program
     {
          static void Main(string[] args)
          {
          }

          public class Solution
          {
               public string DestCity(IList<IList<string>> paths)
               {
                    bool endCityFlag = false;
                    foreach (var path in paths)
                    {
                         string TempCity = path[1];
                         endCityFlag = true;
                         foreach (var path1 in paths)
                         {
                              if (path1[0]==TempCity)
                              {
                                   endCityFlag = false;
                                   break;
                              }
                         }
                         if (endCityFlag)
                         {
                              return TempCity;
                         }
                    }
                    return null;
               }
          }
     }
}
