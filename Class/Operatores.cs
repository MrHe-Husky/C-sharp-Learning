using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatores
{
     class Program
     {
          static void Main(string[] args)
          { 
               //字典，[]中不一定是int型
               Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
               for (int i = 0; i < 100; i++)
               {
                    Student stu = new Student();
                    stu.Name = "s_" + i.ToString();
                    stu.Score = 100 + i;
                    stuDic.Add(stu.Name, stu);
               }
               Console.WriteLine(stuDic["s_19"].Score);
               Console.WriteLine("==================");
               //typeof操作符
               Type t = typeof(int);
               Console.WriteLine(t.Namespace);
               Console.WriteLine(t.FullName);
               Console.WriteLine(t.Name);
               int c = t.GetMethods().Length;
               foreach (var im in t.GetMethods())
               {
                    Console.WriteLine(im.Name);
               }
               Console.WriteLine(c);
               Console.WriteLine("==================");
               //default操作符
               int de = default(int);
               Console.WriteLine(de);
               //枚举类型的default
               Level lev = default(Level);
               Console.WriteLine(lev);
               Console.WriteLine("==================");
               //new操作符
               Student stu1 = new Student();//一般创建实例student
               //创建实例时初始化参数，不使用变量抓捕，建立后过一段时间就被回收，一次性
               new Form() { Text = "Hellow World", FormBorderStyle = FormBorderStyle.FixedToolWindow }.Show();
               //匿名类型new创建
               var Husky = new { Name = "Husky", ID = 5713 };
               Console.WriteLine(Husky.Name);
               Console.WriteLine(Husky.ID);
               Console.WriteLine(Husky.GetType().Name);
               Console.WriteLine("==================");
               //继承中new对父类方法隐藏
               Student stu2 = new Student();
               stu2.Report();
               CSStudent stu3 = new CSStudent();
               stu3.Report();
               Console.WriteLine("==================");
               //checked,unchecked检测溢出,C#默认unchecked
               uint u = uint.MaxValue;
               checked
               {
                    try
                    {
                         u++;//最大值自增1后会产生溢出
                         Console.WriteLine(u);
                    }
                    catch (OverflowException)
                    {
                         Console.WriteLine("There is overflow!");
                    }
               }
               Console.WriteLine("==================");
               //类型转换&convert,自定义类型转换(参考StoneToMonkey.cs，TextAdd.cs)
               string strNum = "1145141919810";
               long tianSuoHaoEr = Convert.ToInt64(strNum);
               string kuSaNum = tianSuoHaoEr.ToString();
               //is,as操作符
               object stone1 = new Stone() { Age = 114514 };
               CSStudent CSStu = new CSStudent();
               bool get = stone1 is Stone;
               Console.WriteLine(get);//ture
               get = CSStu is Student;
               Console.WriteLine(get);//ture
               get = stone1 is Student;
               Console.WriteLine(get);//false
               Stone stoneGetor = stone1 as Stone;
               if (stoneGetor != null)
               {
                    Console.WriteLine(stoneGetor.Age);
               }
               else
               {
                    Console.WriteLine("a null got");
               }
               stoneGetor = (object)CSStu as Stone;
               if (stoneGetor != null)
               {
                    Console.WriteLine(stoneGetor.Age);
               }
               else
               {
                    Console.WriteLine("a null got");
               }
               Console.WriteLine("===================");
               //?? null合并操作符
               int? score = null;//Nullable<int> score = null;
               Console.WriteLine(score);
               int scoreLast = score ?? 0;//score的null值合并至0;
               Console.WriteLine(scoreLast);
          }

          enum Level
          {
               Low,
               Mid,
               High
          }
          class Student
          {
               public string Name;
               public int Score;
               public void Report()
               {
                    Console.WriteLine("I'm a student");
               }
          }
          //CSStudent对类Student继承
          class CSStudent : Student
          {
               //用new(修饰符)对方法父类的Report方法进行隐藏
               new public void Report()
               {
                    Console.WriteLine("I'm a Computer Science student");
               }
          }
          class Stone
          {
               public int Age;
          }
     }
}
