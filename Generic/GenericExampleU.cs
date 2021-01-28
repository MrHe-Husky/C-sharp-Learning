using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExampleU
{
     class Program
     {
          static void Main(string[] args)
          {
               IList<int> list = new List<int>();//泛型接口变量引用实例
               for (int i = 0; i <= 100; i++)
               {
                    list.Add(i);
               }
               foreach (var item in list)
               {
                    Console.WriteLine(item);
               }

               IDictionary<int, string> dict = new Dictionary<int, string>();
               dict[1] = "花Q";
               dict[2] = "哼哼哼~啊啊啊啊啊啊啊啊啊啊啊啊啊啊";
               Console.WriteLine(dict[1]);
               Console.WriteLine(dict[2]);


               Console.WriteLine("=====================");
               int[] a1 = { 1, 2, 3, 4, 5, 6 };
               int[] a2 = new int[] { 1, 2, 3, 4, 5, 6 };
               double[] a3 = new double[6] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
               var a4 = new double[6] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
               var result1 = Zip(a1, a2);//十分智能的一点，直接根据参数的类型决定了result1的类型
               Console.WriteLine(string.Join(",", result1));
               var result2 = Zip<double>(a3, a4);
               Console.WriteLine(string.Join(",",result2));

               Console.WriteLine("=====================");
               //泛型委托Action
               Action<string> action1 = CallSomeBody;
               action1.Invoke("花Q");
               Action<int> action2 = Mul100;
               action2.Invoke(114514);
               //泛型委托Func
               Func<int, int, int> func1 = Add;
               Func<double, double, double> func2 = Add;
               func1.Invoke(114000, 514);
               func2.Invoke(114, 0.514);
               //lambda表达式声明泛型委托
               Func<ulong, ulong, ulong> func3 = (ulong a, ulong b) => { return a + b; };
               func3.Invoke(114, 514);
               //类型名可去除
               Func<string, string, string> func4 = (a, b) => { return a + b; };
               func4.Invoke("哼哼哼~", "啊啊啊啊啊啊啊啊啊啊啊啊啊！！！！！！");
          }

          static T[] Zip<T>(T[] a,T[] b)//泛型方法
          {
               T[] zipped = new T[a.Length + b.Length];
               int j = 0;
               for (int i = 0; i < a.Length; i++)
               {
                    zipped[j++] = a[i];
                    zipped[j++] = b[i];
               }
               return zipped;
          }

          static void CallSomeBody(string Name)
          {
               Console.WriteLine($"You suck, {Name}!");
          }

          static void Mul100(int x)
          {
               Console.WriteLine(x * 100);
          }

          static double Add(double a,double b)
          {
               return a + b;
          }
          static int Add(int a,int b)
          {
               return a + b;
          }
     }
}
