using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
     class Program
     {
          static void Main(string[] args)
          {
               Student stu1 = new Student("025713", "Husky");
               Console.WriteLine(stu1.ID);
               Console.WriteLine(stu1.StudentName);
               Console.WriteLine("==============");
               Student stu810 = new Student();
               Console.WriteLine(stu810.ID);
               Console.WriteLine(stu810.StudentName);
               Console.WriteLine("==============");
               Console.WriteLine();
               Console.WriteLine("The student amount is: {0}", Student.Amount);
               Console.WriteLine("==============");
               Console.WriteLine("The student amount is: {0}", Student.Amount);
          }
     }

     class Student
     {
          //构造器
          public Student()
          {
               this.ID = "114514";
               this.StudentName = "田所浩二";
               Amount++;
          }
          //重载构造器
          public Student(string InPutID, string InPutName)
          {
               this.ID = InPutID;
               this.StudentName = InPutName;
               Amount++;
          }
          //快捷键:ctor   double-tabkey
          static Student()//静态构造器，在应用此类时初始化一次
          {
               Amount = 0;
          }
          public string ID;//field，字段;public string ID = 114514，相当于使用构造器初始化为114514;
          public string StudentName;
          public static int Amount;//静态字段
          ~Student() //析构函数，不可重载
          {
               Amount--;
               Console.WriteLine("{0} has been killed", this.StudentName);
          }
     }
}
