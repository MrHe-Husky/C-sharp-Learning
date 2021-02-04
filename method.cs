using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
     class Program
     {
          static void Main(string[] args)
          {
               double x;
               x = Calculator.Add(114.514, 1919.810);
               Console.WriteLine(x);

               int z;
               z = Calculator.Add(5, 6);
               Console.WriteLine(z);

               double y;
               Calculator c = new Calculator();
               y = c.Sub(114.514, 1919.810);
               Console.WriteLine(y);

               double CircleArea = Calculator.GetCircleArea(5);
               Console.WriteLine(CircleArea);
          }

          class Calculator
          {
               public static double Add(double a,double b)
               {
                    return a + b;
               }
               //Add方法重载，使其也可以计算int型加法
               public static int Add(int a,int b)
               {
                    return a + b;
               }

               public double Sub(double a,double b)
               {
                    return a - b;
               }
               public static double GetCircleArea(double r)
               {
                    return Math.PI * r * r;
               }
          }
     }
}
