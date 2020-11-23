using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomPointInCircle478
{
     class Program
     {
          static void Main(string[] args)
          {
               Random rd = new Random();
               double radius, x_center, y_center;
               radius = 8;
               x_center = 2;
               y_center = 7;
               Solution obj = new Solution(radius, x_center, y_center);
               double[] param_1 = obj.RandPoint();
               Console.WriteLine($"随机点X：{param_1[0]},随机点Y：{param_1[1]}");
               bool Successed = false;
               Successed = (Math.Pow((param_1[0] - x_center), 2) + Math.Pow((param_1[1] - y_center), 2)) < (radius * radius);
               Console.WriteLine(Successed);
               Console.ReadKey();
          }
     }

     public class Solution
     {
          double radius;
          double centerX;
          double centerY;
          public Solution(double radius, double x_center, double y_center)
          {
               this.radius = radius;
               this.centerX = x_center;
               this.centerY = y_center;
          }

          public double[] RandPoint()
          {
               double[] param = new double[] { -1, -1 };
               double tempX, tempY;
               Random rd = new Random();
               do
               {
                    tempX = centerX + (2 * rd.NextDouble() - 1) * radius;
                    tempY = centerY + (2 * rd.NextDouble() - 1) * radius;
               } while ((param[0]-centerX)*(param[0] - centerX) + (param[1] - centerY)*(param[1] - centerY) < (radius * radius));
               param[0] = tempX;
               param[1] = tempY;
               return param;
          }
     }
     /*
      public class Solution
     {
          double radius;
          double centerX;
          double centerY;
          public Solution(double radius, double x_center, double y_center)
          {
               this.radius = radius;
               this.centerX = x_center;
               this.centerY = y_center;
          }

          public double[] RandPoint()
          {
               double[] param = new double[] { -1, -1 };
               double tempX, tempY;
               Random rd = new Random();
               tempX = centerX + (2 * rd.NextDouble() - 1) * radius;
               tempY = centerY + (2 * rd.NextDouble() - 1) * Math.Sqrt(radius * radius - (tempX-centerX) * (tempX-centerX));
               param[0] = tempX;
               param[1] = tempY;
               return param;
          }
     }
     */
}
